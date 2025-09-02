using AmazonAPI.Data;
using AmazonAPI.Models;
using AmazonAPI.Models.ModelClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazonOrdersController : ControllerBase
    {
        private readonly AmazonDbContext _context;
        private readonly WestendAccountsDbContext _context1;
        private readonly ILogger<AmazonOrdersController> _logger;

        public AmazonOrdersController(AmazonDbContext context, WestendAccountsDbContext context1, ILogger<AmazonOrdersController> logger)
        {
            _context = context;
            _context1 = context1;
            _logger = logger;
        }

        [HttpGet("stats")]
        public async Task<IActionResult> GetOrderStats()
        {
            try
            {
                var results = await _context.AmazonOrdersStats
                    .FromSqlRaw("EXEC dbo.AmazonOrdersStats")
                    .AsNoTracking() // Recommended for read-only operations
                    .ToListAsync();

                return Ok(results);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error executing AmazonOrdersStats procedure");
                return StatusCode(500, new
                {
                    error = "Error retrieving order statistics",
                    details = ex.Message
                });
            }
        }

     
        [Produces("application/json")]
        [ProducesResponseType(typeof(AmazonDashboardViewModel), StatusCodes.Status200OK)]
        [HttpGet("AmazonOrdersstats")]
        public async Task<IActionResult> GetAmazonOrderStats(string period = "current")
        {
            try
            {
                // Validate period parameter
                if (!new[] { "current", "previous", "yeartodate" }.Contains(period.ToLower()))
                {
                    return BadRequest("Invalid period value. Valid values are: current, previous, yeartodate");
                }

                var currentDate = DateTime.Now;
                var usCulture = new CultureInfo("en-US");

                // Get the where clause with parameters
                var (whereClause, parameters) = GetWhereClauseWithParameters(period, currentDate);

                // Debug: Log the SQL query being executed
                _logger.LogInformation("Executing query with WHERE clause: {whereClause}", whereClause);

                // Get orders
                var filteredOrders = await _context.AmazonAllPnLs
                    .FromSqlRaw($"SELECT * FROM AmazonAllPnL WHERE {whereClause}", parameters.ToArray())
                    .AsNoTracking()
                    .ToListAsync();

                // Debug: Log number of orders found
                _logger.LogInformation("Found {count} orders", filteredOrders.Count);

                // Get metrics with proper column aliases
                var orderCount = await _context.Database
                    .SqlQueryRaw<int>($"SELECT COUNT(*) AS Value FROM AmazonAllPnL WHERE {whereClause}", parameters.ToArray())
                    .FirstOrDefaultAsync();

                var totalProfit = await _context.Database
                    .SqlQueryRaw<double?>($"SELECT SUM(EstimatedProfit) AS Value FROM AmazonAllPnL WHERE {whereClause}", parameters.ToArray())
                    .FirstOrDefaultAsync();

                var totalPurchases = await _context.Database
                    .SqlQueryRaw<double?>($"SELECT SUM(PurchaseTotalWithTax) AS Value FROM AmazonAllPnL WHERE {whereClause}", parameters.ToArray())
                    .FirstOrDefaultAsync();

                var totalFreight = await _context.Database
                    .SqlQueryRaw<decimal?>($"SELECT SUM(Freight) AS Value FROM AmazonAllPnL WHERE {whereClause}", parameters.ToArray())
                    .FirstOrDefaultAsync();

                var totalSales = await _context.Database
                    .SqlQueryRaw<decimal?>($"SELECT SUM(SellingTotal) AS Value FROM AmazonAllPnL WHERE {whereClause}", parameters.ToArray())
                    .FirstOrDefaultAsync();

                var totalMarketplaceFee = await _context.Database
                    .SqlQueryRaw<double?>($"SELECT SUM(MarketplaceFee) AS Value FROM AmazonAllPnL WHERE {whereClause}", parameters.ToArray())
                    .FirstOrDefaultAsync();

                // Debug: Log all metric values
                _logger.LogInformation("Metrics - OrderCount: {orderCount}, TotalProfit: {totalProfit}", orderCount, totalProfit);

                var metrics = new DashboardMetrics
                {
                    OrderCount = orderCount,
                    TotalProfit = totalProfit.HasValue ? (decimal)totalProfit : 0m,
                    TotalPurchases = totalPurchases.HasValue ? (decimal)totalPurchases : 0m,
                    TotalFreight = totalFreight.HasValue ? totalFreight.Value : 0m,
                    TotalSales = totalSales.HasValue ? totalSales.Value : 0m,
                    TotalMarketplaceFee = totalMarketplaceFee.HasValue ? (decimal)totalMarketplaceFee : 0m,
                    CultureInfo = usCulture,
                    PeriodDisplay = period switch
                    {
                        "current" => "Current Month",
                        "previous" => "Previous Month",
                        "yeartodate" => "Year to Date",
                        _ => period
                    }
                };

                var model = new AmazonDashboardViewModel
                {
                    AllOrders = filteredOrders,
                    CurrentMonthOrders = filteredOrders,
                    SelectedPeriod = period,
                  Metrics= metrics
                };
                // Debug: Log final model before returning
                _logger.LogInformation("Returning model with {orderCount} orders", model.AllOrders.Count);

                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving order statistics");
                return StatusCode(500, new
                {
                    error = "Error retrieving order statistics",
                    details = ex.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }

        private (string whereClause, List<SqlParameter> parameters) GetWhereClauseWithParameters(string period, DateTime currentDate)
        {
            var parameters = new List<SqlParameter>();
            string whereClause;

            switch (period.ToLower())
            {
                case "previous":
                    var firstDayOfPreviousMonth = new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(-1);
                    var lastDayOfPreviousMonth = firstDayOfPreviousMonth.AddMonths(1).AddDays(-1);

                    parameters.Add(new SqlParameter("@startDate", firstDayOfPreviousMonth));
                    parameters.Add(new SqlParameter("@endDate", lastDayOfPreviousMonth));
                    whereClause = "PurchaseDate >= @startDate AND PurchaseDate <= @endDate";
                    break;

                case "yeartodate":
                    var firstDayOfYear = new DateTime(currentDate.Year, 1, 1);

                    parameters.Add(new SqlParameter("@startDate", firstDayOfYear));
                    parameters.Add(new SqlParameter("@endDate", currentDate));
                    whereClause = "PurchaseDate >= @startDate AND PurchaseDate <= @endDate";
                    break;

                default: // "current"
                    var firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
                    var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                    parameters.Add(new SqlParameter("@startDate", firstDayOfMonth));
                    parameters.Add(new SqlParameter("@endDate", lastDayOfMonth));
                    whereClause = "PurchaseDate >= @startDate AND PurchaseDate <= @endDate";
                    break;
            }

            return (whereClause, parameters);
        }

        [AllowAnonymous]
        [HttpGet("AmazonDashboard")]
        public async Task<IActionResult> AmazonDashboard()
        {
         
            var companiespayableSummary = await _context1.ViewAccountPayableByCompanies
                .OrderByDescending(x => x.TotalBill)
                .Take(3)
                .ToListAsync();

            var companiessummary = await _context1.ViewAccountsReceivableByCompanies
                .Where(x => x.Name.Contains("Amazon DTS"))
                .OrderByDescending(x => x.TotalInv)
                .Take(3)
                .ToListAsync();

            var total = companiessummary.Sum(x => x.TotalInv);
            var payabletotal = companiespayableSummary.Sum(x => x.TotalBill);

            var amazonorderUnshipped = await _context.Set<AmazonNotShippedModel>()
                .FromSqlRaw("EXEC AmazonOrdersUnShipped")
                .ToListAsync();

            var amazonordershipped = await _context.Set<AmazonShippedModel>()
                .FromSqlRaw("EXEC AmazonOrdersShipped")
                .ToListAsync();

            var amazonorderstats = await _context.Set<AmazonOrdersStats>()
                .FromSqlRaw("EXEC AmazonOrdersStats")
                .ToListAsync();

            var results = await _context1.Set<InvModel>()
                .FromSqlRaw(@"
            SELECT CAST(i.InvoiceDate AS date) AS Date, c.CompanyName, 
                   FORMAT(i.InvoiceTotal, 'c') AS Total, 
                   CASE WHEN IsPaid = 0 THEN 'Unpaid' ELSE 'Paid' END AS Status
            FROM dbo.Invoices AS i 
            INNER JOIN dbo.ContactCompany AS c ON c.ContactCompanyID = i.ContactID
            WHERE (YEAR(i.InvoiceDate) = YEAR(GETDATE())) 
                  AND (i.CompanyID IN (3, 4, 15, 23, 24, 25)) 
                  AND (CAST(i.InvoiceDate AS date) >= CAST(GETDATE() - 45 AS date)) 
                  AND (c.ContactCompanyID NOT IN (4239, 7860))
        ")
                .OrderByDescending(x => x.Date)
                .Take(5)
                .ToListAsync();

            var invoiceslistview = results.Take(3).OrderByDescending(x => x.Total);

            var response = new
            {
                CompaniesPayableSummary = companiespayableSummary,
                CompaniesSummary = companiessummary,
                Total = total,
                PayableTotal = payabletotal,
                AmazonOrderUnshipped = amazonorderUnshipped,
                AmazonOrderShipped = amazonordershipped,
                AmazonOrderStats = amazonorderstats,
                InvoicesListView = invoiceslistview
            };

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("SaleDashboard")]
        public async Task<IActionResult> SaleDashboard()
        {
            try
            {               
                // Get companies payable summary
                var companiespayableSummary = await _context1.ViewAccountPayableByCompanies
                    .OrderByDescending(x => x.TotalBill)
                    .Take(3)
                    .ToListAsync();

                // Get companies receivable summary
                var companiessummary = await _context1.ViewAccountsReceivableByCompanies
                    .OrderByDescending(x => x.TotalInv)
                    .Take(3)
                    .ToListAsync();

                //result.CompaniesSummary = companiessummary;
                var TotalReceivable = companiessummary.Select(x => x.TotalInv).Sum();
                var TotalPayable = companiespayableSummary.Select(x => x.TotalBill).Sum();

                // Get Amazon data using stored procedures
                var amazonOrderUnshipped = await _context.Database
                    .SqlQueryRaw<AmazonNotShippedModel>("EXEC AmazonOrdersUnShipped")
                    .ToListAsync();

                var amazonOrderShipped = await _context.Database
                    .SqlQueryRaw<AmazonShippedModel>("EXEC AmazonOrdersShipped")
                    .ToListAsync();

                var amazonOrderStats = await _context.Database
                    .SqlQueryRaw<AmazonOrdersStats>("EXEC AmazonOrdersStats")
                    .ToListAsync();

                // Get invoices data
                var invoicesQuery = @"
                        SELECT CAST(i.InvoiceDate AS date) AS Date, 
                               c.CompanyName, 
                               FORMAT(i.InvoiceTotal, 'c') AS Total, 
                               CASE WHEN IsPaid = 0 THEN 'Unpaid' ELSE 'Paid' END AS Status
                        FROM dbo.Invoices AS i 
                        INNER JOIN dbo.ContactCompany AS c ON c.ContactCompanyID = i.ContactID
                        WHERE (YEAR(i.InvoiceDate) = YEAR(GETDATE())) 
                            AND (i.CompanyID IN (3, 4, 15, 23, 24, 25)) 
                            AND (CAST(i.InvoiceDate AS date) >= CAST(GETDATE() - 45 AS date)) 
                            AND (c.ContactCompanyID NOT IN (4239, 7860))
                        ";

                var results = await _context1.Database
                    .SqlQueryRaw<InvModel>(invoicesQuery)
                    .Take(5)
                    .ToListAsync();

                var invoiceslistview = results.Take(3).OrderByDescending(x => x.Total);

                var response = new
                {
                    CompaniesPayableSummary = companiespayableSummary,
                    CompaniesSummary = companiessummary,
                    Total = TotalReceivable,
                    PayableTotal = TotalPayable,
                    AmazonOrderUnshipped = amazonOrderUnshipped,
                    AmazonOrderShipped = amazonOrderShipped,
                    AmazonOrderStats = amazonOrderStats,
                    InvoicesListView = invoiceslistview
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred in SaleDashboard");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        // GET: api/AmazonOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders.Take(20).OrderByDescending(x=>x.OrderId).ToListAsync();
        }

        // GET: api/AmazonOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/AmazonOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PutOrder")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AmazonOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        // DELETE: api/AmazonOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}

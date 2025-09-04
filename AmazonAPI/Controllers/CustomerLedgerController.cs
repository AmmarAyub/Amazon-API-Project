using AmazonAPI.Data;
using AmazonAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerLedgerController : ControllerBase
    {
        private readonly WestendAccountsDbContext _context1;
        private readonly ILogger<CustomerLedgerController> _logger;
        public CustomerLedgerController(WestendAccountsDbContext context1, ILogger<CustomerLedgerController> logger)
        {
            _context1 = context1;
            _logger = logger;
        }
        [HttpPost("InvoiceSelectDate")]
        public async Task<ActionResult> InvoiceSelectDate([FromBody] PagedRequest request)
        {
            try
            {
                // Build the SQL query
                var sqlQuery = @"
                SELECT top 100
                    Name, [CompanyName], 'Invoice' as TypeofTran,
                    ExternalInvoiceNO as Ref, [InvoiceID],
                    FORMAT([InvoiceDate], 'yyyy-MM-dd') as Dates,
                    [InvoiceTotal]
                FROM [WestendAccounts].[dbo].[View_InvoiceRegister]
                UNION
                SELECT  
                    Name, [CompanyName], 'Receipt' as TypeofTran,
                    PORefrence as Ref, [InvoiceID],
                    FORMAT([Date_Received], 'yyyy-MM-dd') as Dates,
                    [InvoiceTotal]
                FROM [WestendAccounts].[dbo].[View_InvoicesReceipts]
                ";

                // Execute the raw SQL query
                var invoices = await _context1.InvoiceModels
                    .FromSqlRaw(sqlQuery)
                    .OrderByDescending(x => x.Dates)
                    .Skip((request.Page - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToListAsync();

                // Apply date filtering if dates are provided
                if (request.StartDate.HasValue && request.EndDate.HasValue)
                {
                    invoices = invoices.Where(x =>
                        DateTime.Parse(x.Dates) >= request.StartDate.Value &&
                        DateTime.Parse(x.Dates) <= request.EndDate.Value)
                        .ToList();
                }
                var totalinv = invoices.Count;
                return Ok(new PagedResponse<InvoiceModel>
                {
                    Data = invoices,
                    TotalCount = totalinv,
                    CurrentPage = request.Page,
                    TotalPages = (int)Math.Ceiling(totalinv / (double)request.PageSize),
                    HasMore = request.Page * request.PageSize < totalinv
                });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving invoice data");
                return StatusCode(500, new { error = "An error occurred while retrieving invoice data" });
            }
        }

        [HttpPost("BillSelectDate")]
        public async Task<ActionResult> BillSelectDate([FromBody] PagedRequest request)
        {
            try
            {
                // Build the SQL query
                var sqlQuery = @"
                SELECT 
                    Name, CompanyName, 'Bill' as TypeofTran,
                    PORefrence as Ref, BillID,
                    FORMAT(BillDate, 'yyyy-MM-dd') as Date,
                    BillTotal
                FROM [WestendAccounts].[dbo].[View_BillRegister]
                UNION
                SELECT  
                    Name, CompanyName, 'Receipt' as TypeofTran,
                    PORefrence as Ref, BillID,
                    FORMAT(Date_Received, 'yyyy-MM-dd') as Date,
                    BillTotal
                FROM [WestendAccounts].[dbo].[View_BillPayments]
                ";

                // Execute the raw SQL query
                var bills = await _context1.BillModels
                    .FromSqlRaw(sqlQuery)
                    .OrderByDescending(x => x.Date)
                    .Skip((request.Page - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToListAsync();

                // Apply date filtering if dates are provided
                if (request.StartDate.HasValue && request.EndDate.HasValue)
                {
                    bills = bills.Where(x =>
                        DateTime.Parse(x.Date) >= request.StartDate.Value &&
                        DateTime.Parse(x.Date) <= request.EndDate.Value)
                        .ToList();
                }

                var totalbills = bills.Count;

                return Ok(new PagedResponse<BillModel>
                {
                    Data = bills,
                    TotalCount = totalbills,
                    CurrentPage = request.Page,
                    TotalPages = (int)Math.Ceiling(totalbills / (double)request.PageSize),
                    HasMore = request.Page * request.PageSize < totalbills
                });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving bill data");
                return StatusCode(500, new { error = "An error occurred while retrieving bill data" });
            }
        }

        [HttpPost("TransactionDateFilter")]
        public async Task<ActionResult> TransactionDateFilter([FromBody] PagedRequest request)
        {
            try
            {
                var query = _context1.Transactions.AsQueryable();

                if (request.StartDate.HasValue && request.EndDate.HasValue)
                {
                    query = query.Where(x => x.Date >= request.StartDate.Value && x.Date <= request.EndDate.Value);
                }

                var totalCount = await query.CountAsync();
                var transactions = await query
                    .OrderByDescending(t => t.Date)
                    .Skip((request.Page - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(t => new TransactionModel
                    {
                        ID = t.Id,
                        Account_Id = (Convert.ToString(t.AccountId)),
                        Date = t.Date,
                        Description = t.Description,
                        Original_Description = t.OriginalDescription,
                        Amount = (decimal?)t.Amount,
                        Transaction_Type = t.TransactionType,
                        Category = t.Category,
                        SubCategory = t.SubCategory,
                        Labels = t.Labels,
                        Notes = t.Notes,
                        Account_Type = t.AccountType,
                        PreviouslyChargedTo = t.PreviouslyChargedTo,
                        CompanyCharged = t.CompanyCharged,
                        Personal = t.Personal,
                        Accountname = t.Account.AccountName
                    })
                    .ToListAsync();

                return Ok(new PagedResponse<TransactionModel>
                {
                    Data = transactions,
                    TotalCount = totalCount,
                    CurrentPage = request.Page,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize),
                    HasMore = request.Page * request.PageSize < totalCount
                });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error filtering transactions by date");
                return StatusCode(500, new { error = "An error occurred while filtering transactions" });
            }
        }

        [HttpPost("LoadTransactions")]
        public async Task<ActionResult> LoadTransactions([FromBody] PagedRequest request)
        {
            try
            {
                var query = _context1.Transactions.AsQueryable();

                if (request.StartDate.HasValue && request.EndDate.HasValue)
                {
                    query = query.Where(x => x.Date >= request.StartDate.Value && x.Date <= request.EndDate.Value);
                }

                var totalCount = await query.CountAsync();
                var transactions = await query
                    .OrderByDescending(t => t.Date)
                    .Skip((request.Page - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(t => new TransactionModel
                    {
                        Date = t.Date,
                        Original_Description = t.OriginalDescription,
                        Account_Id = t.AccountId.ToString(),
                        CompanyCharged = t.CompanyCharged,
                        Transaction_Type = t.TransactionType,
                        Amount = (decimal?)t.Amount
                    })
                    .ToListAsync();

                return Ok(new PagedResponse<TransactionModel>
                {
                    Data = transactions,
                    TotalCount = totalCount,
                    CurrentPage = request.Page,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize),
                    HasMore = request.Page * request.PageSize < totalCount
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading transactions");
                return StatusCode(500, new { error = "An error occurred while loading transactions" });
            }
        }

        [HttpPost("LoadCustomers")]
        public async Task<ActionResult> LoadCustomers([FromBody] PagedRequest request)
        {
            try
            {
                var sqlQuery = @"
                SELECT 
                    Name, CompanyName, 'Invoice' as TypeofTran,
                    ExternalInvoiceNO as Ref, InvoiceID,
                    FORMAT(InvoiceDate, 'd', 'en-us') as Dates,
                    InvoiceTotal
                FROM View_InvoiceRegister
                UNION
                SELECT  
                    Name, CompanyName, 'Receipt' as TypeofTran,
                    PORefrence as Ref, InvoiceID,
                    FORMAT(Date_Received, 'd', 'en-us') as Dates,
                    InvoiceTotal
                FROM View_InvoicesReceipts
                ORDER BY Dates ASC";

                // Get all records first for total count (consider optimizing this for large datasets)
                var allInvoices = await _context1.InvoiceModels
                    .FromSqlRaw(sqlQuery)
                    .ToListAsync();

                // Apply date filtering if provided
                if (request.StartDate.HasValue && request.EndDate.HasValue)
                {
                    allInvoices = allInvoices.Where(x =>
                        DateTime.Parse(x.Dates) >= request.StartDate.Value &&
                        DateTime.Parse(x.Dates) <= request.EndDate.Value)
                        .ToList();
                }

                var totalCount = allInvoices.Count;
                var customers = allInvoices
                    .Skip((request.Page - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToList();

                return Ok(new PagedResponse<InvoiceModel>
                {
                    Data = customers,
                    TotalCount = totalCount,
                    CurrentPage = request.Page,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize),
                    HasMore = request.Page * request.PageSize < totalCount
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading customers data");
                return StatusCode(500, new { error = "An error occurred while loading customers data" });
            }
        }

        [HttpPost("LoadVendors")]
        public async Task<ActionResult> LoadVendors([FromBody] PagedRequest request)
        {
            try
            {
                var sqlQuery = @"
                SELECT 
                    Name, CompanyName, 'Bill' as TypeofTran,
                    PORefrence as Ref, BillID,
                    FORMAT(BillDate, 'd', 'en-us') as Date,
                    BillTotal
                FROM View_BillRegister
                UNION
                SELECT  
                    Name, CompanyName, 'Receipt' as TypeofTran,
                    PORefrence as Ref, BillID,
                    FORMAT(Date_Received, 'd', 'en-us') as Date,
                    BillTotal
                FROM View_BillPayments
                ORDER BY Date ASC";

                // Get all records first
                var allBills = await _context1.BillModels
                    .FromSqlRaw(sqlQuery)
                    .ToListAsync();

                // Apply date filtering if provided
                if (request.StartDate.HasValue && request.EndDate.HasValue)
                {
                    allBills = allBills.Where(x =>
                        DateTime.Parse(x.Date) >= request.StartDate.Value &&
                        DateTime.Parse(x.Date) <= request.EndDate.Value)
                        .ToList();
                }

                var totalCount = allBills.Count;
                var vendors = allBills
                    .Skip((request.Page - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToList();

                return Ok(new PagedResponse<BillModel>
                {
                    Data = vendors,
                    TotalCount = totalCount,
                    CurrentPage = request.Page,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize),
                    HasMore = request.Page * request.PageSize < totalCount
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading vendors data");
                return StatusCode(500, new { error = "An error occurred while loading vendors data" });
            }
        }

    }
}

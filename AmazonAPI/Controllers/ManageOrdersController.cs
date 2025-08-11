using AmazonAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageOrdersController : ControllerBase
    {
        private readonly AmazonDbContext _context;

        public ManageOrdersController(AmazonDbContext context)
        {
            _context = context;
        }

        [HttpGet("orders")]
        public async Task<IActionResult> GetOrder()
        {
            try
            {
                var results = await _context.Orders.Take(20).OrderByDescending(x => x.OrderId).ToListAsync();

                return Ok(results);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error executing AmazonOrdersStats procedure");
                return StatusCode(500, new
                {
                    error = "Error retrieving orders",
                    details = ex.Message
                });
            }
        }
    }
}

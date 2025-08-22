using AmazonAPI.Data;
using AmazonAPI.Models;
using AmazonAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly WestendAccountsDbContext _context1;
        public ProductsController(WestendAccountsDbContext context)
        {
            _context1 = context;
           
        }
        [HttpGet("Productslist")]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await _context1.Products.Take(100).OrderByDescending(x=>x.ProductId).ToListAsync();

                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = "Error retrieving users",
                    details = ex.Message
                });
            }
        }

        // GET: api/Products/5
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProducts(int id)
        {
            var product = await _context1.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}

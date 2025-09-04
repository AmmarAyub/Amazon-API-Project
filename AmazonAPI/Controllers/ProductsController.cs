using AmazonAPI.Data;
using AmazonAPI.Models;
using AmazonAPI.Models.DTO_s;
using AmazonAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly WestendAccountsDbContext _context1;
        //private readonly IMapper _mapper;
        public ProductsController(WestendAccountsDbContext context1)
        {
            _context1 = context1;

        }
        [HttpGet("Productslist")]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await _context1.Products.Take(1000).OrderByDescending(x=>x.ProductId).ToListAsync();

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
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _context1.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products/CreateProduct
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(ProductsDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = new Product(){
                //ProductId = productDto.ProductId,
                ProductName = productDto.ProductName,
                ItemCode = productDto.ItemCode,
                UnitPrice = productDto.UnitPrice,
                Status = productDto.Status,
                IsTrackable = productDto.IsTrackable,
                HstryUserId = productDto.HstryUserId,
                HstryDateTime = DateTime.Now
            };

            //var product = _mapper.Map<Product>(productDto);

            _context1.Products.Add(product);
            await _context1.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, product);
        }

        // PUT: api/Products/UpdateProduct/5
        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(int id, ProductsDTO productDto)
        {
            if (id != productDto.ProductId)
            {
                return BadRequest("Product ID mismatch.");
            }

            var existingProduct = await _context1.Products.FindAsync(id);
            if (existingProduct == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            // Validate required fields
            if (string.IsNullOrEmpty(productDto.ProductName))
            {
                return BadRequest("Product name is required.");
            }

            if (string.IsNullOrEmpty(productDto.HstryUserId))
            {
                return BadRequest("History user ID is required.");
            }

            // Use helper method for mapping
            MapDtoToProduct(productDto, existingProduct);
            existingProduct.HstryDateTime = DateTime.UtcNow;

            _context1.Entry(existingProduct).State = EntityState.Modified;

            try
            {
                await _context1.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound(new { message = $"Product with ID {id} no longer exists." });
                }
                else
                {
                    throw;
                }
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new
                {
                    error = "An error occurred while updating the product",
                    details = ex.InnerException?.Message ?? ex.Message
                });
            }

            return Ok(new
            {
                message = "Product updated successfully",
                productId = existingProduct.ProductId
            });
        }

        // Helper method for manual mapping
        private void MapDtoToProduct(ProductsDTO source, Product destination)
        {
            destination.ProductName = source.ProductName;
            destination.UnitPrice = source.UnitPrice;
            destination.Status = source.Status;
            destination.ItemCode = source.ItemCode;
            destination.IsTrackable = source.IsTrackable;
            destination.HstryUserId = source.HstryUserId;
        }

        // Helper method to check if product exists
        private bool ProductExists(int id)
        {
            return _context1.Products.Any(e => e.ProductId == id);
        }
    }
}

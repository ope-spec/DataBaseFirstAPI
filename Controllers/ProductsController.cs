using DbFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; // Add this for LINQ

namespace DbFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Test1Context _context;

        public ProductsController(Test1Context context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("productNamesAndDescription")]
        public async Task<ActionResult<List<VwNames>>> GetProductNames()
        {
            return Ok(await _context.VwNames.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound(); // Return 404 if not found
            }

            return Ok(product); // Return the product if found
        }

        [HttpGet("productIdAndNames")]
        public async Task<ActionResult<List<ProductDto>>> GetProductSummary()
        {
            var productSummary = await _context.Products
                .Select(p => new ProductDto
                {
                    ProductId = p.ProductId,
                    ProductDescription = p.ProductDescription
                })
                .ToListAsync();

            return Ok(productSummary);
        }

        [HttpPost]
        [Route("addNewProducts")]
        public async Task<IActionResult> AddProduct(Products newProduct)
        {
            if (newProduct == null || newProduct.ProductId == 0)
            {
                return BadRequest("Unable to add new product: Product ID cannot be zero.");
            }

            try
            {
                _context.Products.Add(newProduct);
                await _context.SaveChangesAsync();

                return Ok(new { Message = "New product added successfully.", Product = newProduct });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Unable to add new product.", Error = ex.Message });
            }
        }

        [HttpPut]
        [Route("updateExistingproducts")]
        public async Task<ActionResult> UpdateProduct(Products updatedProduct)
        {
            var product = await _context.Products.FindAsync(updatedProduct.ProductId);

            if (product == null)
            {
                return NotFound();
            }

            // Update product properties
            product.ProductName = updatedProduct.ProductName;
            product.Price = updatedProduct.Price;
            product.ProductDescription = updatedProduct.ProductDescription;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Product updated successfully.", Product = updatedProduct});
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound("Product not found.");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Product deleted successfully." });
        }


        private bool Products(int id)
        {
            throw new NotImplementedException();
        }
    }
}

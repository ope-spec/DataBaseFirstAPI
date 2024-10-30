using DbFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbFirst.Controllers
{
    /// <summary>
    /// Controller for managing sales-related operations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly lolContext _lolContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesController"/> class.
        /// </summary>
        /// <param name="lolContext">The database context to interact with the sales data.</param>
        public SalesController(lolContext lolContext)
        {
            this._lolContext = lolContext;
        }

        /// <summary>
        /// Retrieves all sales records.
        /// </summary>
        /// <returns>A list of all <see cref="Sales"/> records.</returns>
        [HttpGet]
        public async Task<ActionResult<List<Sales>>> GetSales()
        {
            return Ok(await _lolContext.Sales.ToListAsync());
        }

        /// <summary>
        /// Retrieves paginated sales records.
        /// </summary>
        /// <param name="pageNumber">The page number to retrieve. Defaults to 1.</param>
        /// <param name="pageSize">The number of records per page. Defaults to 5.</param>
        /// <returns>A paginated list of <see cref="Sales"/> records.</returns>
        [HttpGet("page")]
        public async Task<ActionResult<List<Sales>>> GetSalesByPage(int pageNumber = 1, int pageSize = 5)
        {
            // Validate input
            if (pageNumber < 1)
            {
                return BadRequest("Page number must be greater than zero.");
            }

            // Calculate the records to skip based on the page number and page size
            var sales = await _lolContext.Sales
                .Skip((pageNumber - 1) * pageSize) // Skip records based on the current page
                .Take(pageSize) // Take only the specified number of records
                .ToListAsync();

            return Ok(sales);
        }

        /// <summary>
        /// Retrieves paginated sales records based on the specified request using POST.
        /// </summary>
        /// <param name="request">An object containing page number and page size for pagination.</param>
        /// <returns>A paginated list of <see cref="Sales"/> records.</returns>
        [HttpPost("page")]
        public async Task<ActionResult<List<Sales>>> GetSalesByPage([FromBody] PaginationRequest request)
        {
            // Validate input
            if (request.PageNumber < 1)
            {
                return BadRequest("Page number must be greater than zero.");
            }

            // Calculate the records to skip based on the page number and page size
            var sales = await _lolContext.Sales
                .Skip((request.PageNumber - 1) * request.PageSize) // Skip records based on the current page
                .Take(request.PageSize) // Take only the specified number of records
                .ToListAsync();

            return Ok(sales);
        }

        /// <summary>
        /// Request object for pagination.
        /// </summary>
        public class PaginationRequest
        {
            /// <summary>
            /// The page number to retrieve. Defaults to 1.
            /// </summary>
            public int PageNumber { get; set; } = 1;

            /// <summary>
            /// The number of records per page. Defaults to 5.
            /// </summary>
            public int PageSize { get; set; } = 5;
        }
    }
}

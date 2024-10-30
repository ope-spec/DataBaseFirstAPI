using DbFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        private readonly Test1Context _context;

        public NamesController(Test1Context context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VwNames>>> GetProductNames()
        {
            return Ok(await _context.VwNames.ToListAsync());
        }
    }
}

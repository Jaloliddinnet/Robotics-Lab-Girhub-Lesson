using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Web.Data.Models;

namespace WebApplicationGitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        AppDbContext context;
        public ValuesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await context.Kompyuterlars.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] Kompyuterlar kompyuter)
        {
            await context.Kompyuterlars.AddAsync(kompyuter);
            await context.SaveChangesAsync();
            return Ok(kompyuter);
        }
    }
}

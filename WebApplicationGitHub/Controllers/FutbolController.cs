using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data.Models;

namespace WebApplicationGitHub.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FutbolController : ControllerBase
    {
        AppDbContext context;
        public FutbolController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await context.futbolist.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]Futbol futbol)
        {
            var res = await context.futbolist.AddAsync(futbol);
            await context.SaveChangesAsync();
            return Ok(res);
        }

    }
}

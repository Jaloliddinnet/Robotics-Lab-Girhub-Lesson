using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data.Models;

namespace WebApplicationGitHub.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KompyuterController : ControllerBase
    {
        AppDbContext context;
        public KompyuterController(AppDbContext context)
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
        [HttpDelete]
        public async Task<IActionResult> DeleteKompyuter(int id)
        {
            var kompyuter = await context.universities.FirstOrDefaultAsync(p => p.id == id);
            context.universities.Remove(kompyuter);
            await context.SaveChangesAsync();
            return Ok("Deleted");
        }
    }

}

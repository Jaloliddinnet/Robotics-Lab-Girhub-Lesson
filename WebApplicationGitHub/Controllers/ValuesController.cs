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

[Route("api/[controller]/[action]")]
    [ApiController]
    public class Values1Controller : ControllerBase
    {
        AppDbContext db;
        public Values1Controller(AppDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> ShowUniver()
        {
            return Ok(await db.universities.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddUniver([FromForm]University university)
        {
            await db.universities.AddAsync(university);
            await db.SaveChangesAsync(); 
            return Ok(university);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DelUniver(int id)
        {
            var univer = await db.universities.FirstOrDefaultAsync(p => p.id == id);
            db.universities.Remove(univer);
            await db.SaveChangesAsync();
            return Ok("O'chirildi !");
        }
    }
}

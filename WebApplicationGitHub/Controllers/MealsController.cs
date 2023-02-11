using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data.Models;

namespace WebApplicationGitHub.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        AppDbContext db;
       
        public MealsController(AppDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await db.meals.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Meals meal)
        {
            await db.meals.AddAsync(meal);
            await db.SaveChangesAsync();
            return Ok("Done");
        }

    }
}

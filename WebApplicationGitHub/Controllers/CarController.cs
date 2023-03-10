using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data.Models;

namespace WebApplicationGitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        AppDbContext context;
        public CarController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await context.Mashinalar.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]Car car)
        {
            await context.Mashinalar.AddAsync(car);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}

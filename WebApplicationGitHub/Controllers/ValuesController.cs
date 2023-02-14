using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Web.Data.DTO;
using Web.Data.Models;

namespace WebApplicationGitHub.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        AppDbContext db;
        IMapper mapper;
        public ValuesController(AppDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ShowUniver()
        {
            return Ok(await db.universities.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddUniver([FromForm]AddUniverDto addUniverDto)
        {
            var university = mapper.Map<University>(addUniverDto);
            await db.universities.AddAsync(university);
            await db.SaveChangesAsync(); 
            return Ok(university);
        }
        [HttpPut("UniverName")]
        public async Task<IActionResult> Update(string name,[FromForm]UpdUniverDto updUniver)
        {
            var Olduniver = await db.universities.FirstOrDefaultAsync(u => u.name.ToLower() == name.ToLower());
            if (Olduniver == null) return BadRequest("Ma'lumot topilmadi !!!");
            var NewUniver = mapper.Map<University>(updUniver);
            NewUniver.id = Olduniver.id;
            NewUniver.year = Olduniver.year;
            NewUniver.name = Olduniver.name;
            db.universities.Attach(Olduniver).CurrentValues.SetValues(NewUniver);
            await db.SaveChangesAsync();
            return Ok("Ma'lumotlar yangilandi !");
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DelUniver(int id)
        {
            var univer = await db.universities.FirstOrDefaultAsync(p => p.id == id);
            if (univer == null) return BadRequest("Ma'lumot topilmadi !!!");
            db.universities.Remove(univer);
            await db.SaveChangesAsync();
            return Ok("O'chirildi !");
        }
    }
}

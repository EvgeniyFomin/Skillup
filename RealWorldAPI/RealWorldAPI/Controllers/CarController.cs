using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealWorldAPI.Controllers.Resources;
using RealWorldAPI.DataAccess;
using RealWorldAPI.Models;

namespace RealWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly RealWorldDbContext db;
        private readonly IMapper mapper;

        public CarController(RealWorldDbContext context, IMapper mapper)
        {
            this.db = context;
            this.mapper = mapper;
        }
        //[HttpGet("/api/car")]
        //public async Task<ActionResult<IEnumerable<CarResource>>> GetAllCars()
        //{
        //    var cars = await db.Cars.Include(m => m.Contact).ToListAsync();

        //    return mapper.Map<List<Car>, List<CarResource>>(cars);
        //}

        [HttpGet("/api/HUY")]
        public async Task<ActionResult<string>> GetHuy()
        {
            var cars = await db.Cars.Include(m => m.Contact).ToListAsync();
            return "HUY";
        }

        [HttpPost]
        public async Task<ActionResult<CarResource>> Post(CarResource car)
        {
            if (car == null)
            {
                return BadRequest();
            }
            db.Cars.Add(mapper.Map<CarResource, Car>(car));
            await db.SaveChangesAsync();
            return Ok(car);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarResource>> GetById(int id)
        {
            var car = await db.Cars.FirstOrDefaultAsync(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }
    }
}
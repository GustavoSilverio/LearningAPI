using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCarros.Context;
using ApiCarros.Models;

namespace ApiCarros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // Link do video: https://www.youtube.com/watch?v=oPGhzIrYQXQ&list=TLPQMTYwMzIwMjPGbuQ8HTdsaA&index=5
    public class CarsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("obter-carros")]
        public async Task<IActionResult> GetCars()
        {
            return Ok(new
            {
                sucess = true,
                data = await _context.Cars.ToListAsync()
            });
        }
        
    }
}

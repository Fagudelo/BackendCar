using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackenCars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController(BackendCarsContext context) : ControllerBase
    {
        private BackendCarsContext _context = context;

        [HttpGet]
        public IEnumerable<Cars> GetCars() => [.. _context.Cars];

        [HttpPost]
        public IActionResult AddCar(Cars cars)
        {
            if (cars.Name.Equals (""))
            {
                BadRequest("No se envi{o la información");
            }
            _context.Cars.Add(cars);
            _context.SaveChangesAsync();

            return Ok(cars);
        }
    }
}

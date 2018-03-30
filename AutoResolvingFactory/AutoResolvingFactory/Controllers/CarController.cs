using System;
using AutoResolvingFactory.Cars;
using AutoResolvingFactory.Resolvers;
using Microsoft.AspNetCore.Mvc;

namespace AutoResolvingFactory.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarFactoryResolve _carFactoryResolve;
        
        public CarController(ICarFactoryResolve carFactoryResolve)
        {
            _carFactoryResolve = carFactoryResolve;
        }
        
        // GET
        public IActionResult GetCar([FromQuery] string type)
        {
            Console.WriteLine(Enum.IsDefined(typeof(CarType), type));
            var success = Enum.TryParse<CarType>(type, true, out var carType);

            if (!success)
            {
                return BadRequest();
            }
            
            var carFactory = _carFactoryResolve.Resolve(carType);
            var result = carFactory.CreateCar();

            return Ok(result);
        }
    }
}
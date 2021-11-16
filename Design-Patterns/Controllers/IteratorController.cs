using Domain.Models;
using Iterator.Collections;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IteratorController : ControllerBase
    {
        [HttpGet]
        public Car Get()
        {
            var cars = new List<Car>
            {
                new Car("Model A", Color.Red, 99, "Engine 1"),
                new Car("Model B", Color.Green, 2000, "Engine A"),
                new Car("Model C", Color.Blue, 99, "Engine X")
            };

            // inicializa Iterator
            var iterator = new IteratorRepository<Car, Guid>().GetIterator();

            // adiciona objetos
            iterator.Add(cars);

            // realiza algoritimo de iteração
            var car = iterator.GetNext();

            return car;
        }
    }
}

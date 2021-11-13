using AbstractFactory.AbstractFactories;
using AbstractFactory.ConcreteFactories;
using Domain.Interfaces;
using Domain.Models;
using Factory.ConcreteCreators;
using Factory.Creators;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("creational/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {

        [HttpGet("Factory")]
        public ActionResult<Car> GetFactory(string type)
        {
            ICarFactory _factory;

            switch (type)
            {
                case "tuner":
                    // a factory recebe uma implementação concreta
                    _factory = new TunerFactory();
                    break;
                case "lowrider":
                    _factory = new LowriderFactory();
                    break;
                default:
                    return NotFound(type);
            }

            // o resultado é um tipo concreto
            var result = _factory.Create("Modelo", "Cor");

            return Ok(result);
        }


        [HttpGet("Abstract")]
        public ActionResult<StructResponse> GetAbstract(string type)
        {
            IAbstractFactory _abstractFactory;

            switch (type)
            {
                case "modern":
                    // a factory recebe uma implementação concreta
                    _abstractFactory = new ModernFactory();
                    break;
                case "vintage":
                    _abstractFactory = new VintageFactory();
                    break;
                default:
                    return NotFound(type);
            }

            // o resultado continua sendo do tipo abstrato
            var person = _abstractFactory.CreatePerson();
            var car = _abstractFactory.CreateCar();

            var result = new StructResponse(car, person);

            return Ok(result);
        }

        // apenas para ajudar a retornar as coisas
        public struct StructResponse
        {
            public StructResponse(ICar car, IPerson person)
            {
                Car = car;
                Person = person;
            }

            public ICar Car { get; private set; }
            public IPerson Person { get; private set; }
        }
    }
}

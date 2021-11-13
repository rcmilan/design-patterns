using ChainOfResponsibility.ConcreteHandlers;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("behavioral/[controller]")]
    [ApiController]
    public class ChainOfResponsibilityController : ControllerBase
    {
        [HttpGet]
        public Car Get()
        {
            // cada handler é responsavél por executar uma tarefa especifica
            var carModelHandler = new CarModelHandler();
            var engineHandler = new EngineHandler();
            var colorHandler = new ColorHandler();

            carModelHandler
                .SetNext(engineHandler)
                .SetNext(colorHandler);

            var car = new Car();

            // Executa a sequência de handlers
            carModelHandler.Handle(car);

            return car;
        }
    }
}

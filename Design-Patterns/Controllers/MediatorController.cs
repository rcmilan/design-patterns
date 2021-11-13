using Domain.Base;
using Domain.Models;
using Mediator.Components;
using Mediator.Mediators;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("behavioral/[controller]")]
    [ApiController]
    public class MediatorController : ControllerBase
    {

        [HttpGet]
        public BaseModel<Guid> Get()
        {
            var mediator = new ConcreteMediator<Guid>();

            var producers = new List<Producer<Guid>>
            {
                new Producer<Guid>(mediator),
                new Producer<Guid>(mediator),
                new Producer<Guid>(mediator),
                new Producer<Guid>(mediator),
                new Producer<Guid>(mediator)
            };

            foreach (var p in producers)
            {
                p.Run(new Car());
            }

            var car = new Car();

            producers.Add(new Producer<Guid>(mediator));
            producers.Last().Run(car);

            var consumer = new Consumer<Guid>(mediator);
            consumer.Run(car);

            return consumer.model;

        }
    }
}

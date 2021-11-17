using Microsoft.AspNetCore.Mvc;
using Visitor;
using Visitor.Components;
using Visitor.Visitors;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {

            List<IComponent> components = new()
            {
                new ConcreteComponentA(),
                new ConcreteComponent1()
            };

            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            var visitor2 = new ConcreteVisitorA();
            Client.ClientCode(components, visitor2);
        }
    }
}

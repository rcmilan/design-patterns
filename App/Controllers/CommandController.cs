using Command;
using Command.Commands;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        [HttpGet("simple")]
        public Person SimpleCommand()
        {
            var person = new Person();

            // o invoker chama os métodos execute
            var invoker = new Invoker<Person, int>();

            // podemos parametrizar o invoker com qualquer command
            invoker.SetOnStart(new SimpleCommand(person));

            invoker.DoSomethingImportant(); // executa o command

            return person;
        }

        [HttpGet]
        public Car ComplexCommand()
        {
            var car = new Car();
            var data = "Data 123";

            // o invoker chama os métodos execute
            var invoker = new Invoker<Car, Guid>();

            // o receiver pode ser qualquer classe com lógica de negócio
            // o receiver pode ser acionado pelo command
            var receiver = new Receiver();

            // podemos parametrizar o invoker com qualquer command
            invoker.SetOnFinish(new ComplexCommand(receiver, car, data));

            invoker.DoSomethingImportant(); // executa o command

            return car;
        }
    }
}

using Domain.Models;
using Memento.Caretakers;
using Memento.Originators;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("behavioral/[controller]")]
    [ApiController]
    public class MementoController : ControllerBase
    {

        [HttpGet]
        public Person Get()
        {
            var person = new Person
            {
                FirstName = "Memento",
                LastName = "Memento",
                BirthDate = DateTime.Now
            };

            var originator = new PersonOriginator(person);
            var caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            var history = caretaker.GetHistory();

            caretaker.Undo();
            caretaker.Undo();
            return caretaker.Undo();
        }
    }
}

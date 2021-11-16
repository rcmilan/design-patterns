using Builder.Builders;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("creational/[controller]")]
    [ApiController]
    public class BuilderController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<IPerson>> Get()
        {
            // o Builder ajuda a criar um objeto seguindo uma sequencia de passos
            var person1 = PersonBuilder
                .CreateNewPerson()
                .SetName("Nome da pessoa")
                .SetBirthDate(DateTime.Now)
                .SetJob("Trabalho")
                .Create();

            var person2 = PersonBuilder
                .CreateNewPerson()
                .SetName("Nome 2")
                .SetBirthDate(DateTime.Now.AddDays(1))
                .SetJob("Work")
                .Create();

            var person3 = PersonBuilder
                .CreateNewPerson()
                .SetName("Nome 333")
                .SetBirthDate(DateTime.Now.AddMonths(-2))
                .SetJob("Job")
                .Create();

            var result = new List<Person>
            {
                (Person)person1,
                (Person)person2,
                (Person)person3
            };

            return Ok(result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Visitor;
using Visitor.Base;
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

            List<Place> places = new()
            {
                new Park(),
                new Home()
            };

            var citizen = new Citizen();
            Client.VisitPlaces(places, citizen);

            var tourist = new Tourist();
            Client.VisitPlaces(places, tourist);
        }
    }
}

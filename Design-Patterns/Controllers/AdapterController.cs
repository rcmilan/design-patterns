using Adapter.Adapters;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("structural/[controller]")]
    [ApiController]
    public class AdapterController : ControllerBase
    {
        [HttpGet("Vehicles")]
        public ActionResult<IEnumerable<string>> Vehicles()
        {
            var car = new Car();
            var plane = new Plane();

            // Queremos que Plane funcione como uma classe que implemente IVehicle
            var planeAdapter = new PlaneToVehicleAdapter(plane);

            var vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(planeAdapter);

            var result = new List<string>();

            foreach (var vehicle in vehicles)
                // agora o avião tem o mesmo comportamento do carro
                result.Add(vehicle.Drive());

            return result;
        }

        [HttpGet("Squares")]
        public ActionResult<IEnumerable<ISquare>> Squares()
        {
            Square square = new Square(2, 2);

            var cube = new Cube(3, 3, 3);
            var cubeAdapter = new CubeToSquareAdapter(cube);

            // o Cubo pode ser adicionado numa lista de Quadrados
            var result = new List<ISquare>
            {
                square,
                cubeAdapter
            };

            return result;
        }
    }
}

using Domain.Interfaces;
using Domain.Models;

namespace Adapter.Adapters
{
    public class PlaneToVehicleAdapter : IVehicle
    {
        private readonly Plane _plane;

        public PlaneToVehicleAdapter(Plane plane)
        {
            _plane = plane;
        }

        // Precisamos "traduzir" o comportamento do Plane para se adequar ao comporamento do IVehicle
        public string Drive() => _plane.Fly();
    }
}
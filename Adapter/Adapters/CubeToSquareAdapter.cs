using Domain.Interfaces;
using Domain.Models;

namespace Adapter.Adapters
{
    // Square implementa a interface ISquare
    // Queremos receber um objeto Cube e retornar um tipo que também implemente a interface ISquare

    public class CubeToSquareAdapter : ISquare
    {
        private readonly Cube _cube;

        public CubeToSquareAdapter(Cube cube)
        {
            _cube = cube;
        }

        public int X { get => _cube.X; set => _cube.X = value; }
        public int Y { get => _cube.Z; set => _cube.Z = value; }
    }
}
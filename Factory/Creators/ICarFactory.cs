using Domain.Models;
using System.Drawing;

namespace Factory.Creators
{
    // Factory retorna um tipo concreto
    public interface ICarFactory
    {
        Car Create(string model, Color color);
    }
}

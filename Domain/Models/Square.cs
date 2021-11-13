using Domain.Interfaces;

namespace Domain.Models
{
    public class Square : ISquare
    {
        public Square(int x, int y)
        {
            X = x;
            Y = y; 
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}

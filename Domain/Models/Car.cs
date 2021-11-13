using Domain.Base;
using System;
using System.Drawing;

namespace Domain.Models
{
    public class Car : BaseModel<Guid>
    {
        public Car()
        {
            Id = Guid.NewGuid();
        }

        public Car(string model, Color color, int year, string engine) : this()
        {
            this.Model = model;
            this.Color = color;
            this.Year = year;
            this.Engine = engine;
        }

        public Color Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
    }
}

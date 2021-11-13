using Domain.Base;
using Domain.Interfaces;
using System;
using System.Drawing;

namespace Domain.Models
{
    public class Car : BaseModel<Guid>, ICar, IVehicle
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

        public Car(string model, Color color, int year, string engine, string type) : this(model, color, year, engine)
        {
            this.Type = type;
        }

        public Color Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public string Type { get; set; }
        public string Drive()
        {
            return $"{this.Model} Drive!!!!";
        }
    }
}

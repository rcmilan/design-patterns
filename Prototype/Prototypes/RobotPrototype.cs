using Prototype.Models;

namespace Prototype.Prototypes
{
    public abstract class RobotPrototype
    {
        public RobotPrototype()
        {

        }

        public RobotPrototype(Robot car)
        {
            this.Color = car.Color;
            this.Model = car.Model;
            this.Type = car.Type;
        }

        public string Color { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Cria um clone da classe a partir da mesma
        /// </summary>
        /// <returns>RobotPrototype</returns>
        public abstract RobotPrototype Clone();
    }
}

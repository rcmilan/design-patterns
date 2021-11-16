using Prototype.Prototypes;

namespace Prototype.Models
{
    public class Robot : RobotPrototype
    {
        public int Year { get; set; }

        public Robot()
        {

        }

        public Robot(Robot source) : base(source)
        {
            this.Year = source.Year;
        }

        public override RobotPrototype Clone()
        {
            return new Robot(this);
        }
    }
}

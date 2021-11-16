using Composite.Components;

namespace Composite.Models
{
    public class Computer : IProduct
    {
        private string _brand = "Computer X";

        public Computer()
        {

        }

        public Computer(string brand) : this()
        {
            _brand = brand;
        }

        public string GetBrand()
        {
            return _brand;
        }

        public decimal GetPrice()
        {
            return 123.45m;
        }
    }
}

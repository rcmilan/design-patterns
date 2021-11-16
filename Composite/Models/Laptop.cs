namespace Composite.Models
{
    public class Laptop : Computer
    {
        private decimal _weight;

        public Laptop(string brand, decimal weight) : base(brand)
        {
            this._weight = weight;
        }

        public decimal GetWeight() => _weight;
    }
}

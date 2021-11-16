using Composite.Components;

namespace Composite.Models
{
    public class Phone : IProduct
    {
        private string _label { get; set; }

        public Phone(string label)
        {
            this._label = label;
        }

        public string GetBrand()
        {
            return _label;
        }

        public decimal GetPrice()
        {
            return 99.99m;
        }
    }
}

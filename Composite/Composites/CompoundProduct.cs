using Composite.Components;
using System.Collections.Generic;
using System.Linq;

namespace Composite.Composites
{
    public class CompoundProduct : IProduct
    {
        // CompoundProduct pode fazer parte da lista de children de outro CompoundProduct
        private List<IProduct> _children { get; set; }

        public CompoundProduct()
        {
            _children = new List<IProduct>();
        }

        /// <summary>
        /// Retorna a marca de todos os produtos
        /// </summary>
        /// <returns>string com todos as brands seperadas por ,</returns>
        public string GetBrand()
        {
            var labels = _children.Select(c => c.GetBrand());

            return string.Join(", ", labels);
        }

        /// <summary>
        /// Retorna a soma do preço de todos os produtos
        /// </summary>
        /// <returns>soma dos preços</returns>
        public decimal GetPrice()
        {
            return _children.Sum(c => c.GetPrice());
        }

        public IProduct Add(IProduct product)
        {
            _children.Add(product);
            return product;
        }

        public bool Remove(IProduct product)
        {
            return _children.Remove(product);
        }
    }
}

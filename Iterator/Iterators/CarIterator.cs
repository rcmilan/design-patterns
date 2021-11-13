using Domain.Models;
using Iterator.Interfaces;
using System;
using System.Collections.Generic;

namespace Iterator.Iterators
{
    public class CarIterator : IIteratable<Car, Guid>
    {
        private int _index;
        private IList<Car> _carList;

        public CarIterator()
        {
            _carList = new List<Car>();
        }

        public bool HasNext()
        {
            return _index < _carList.Count;
        }

        // Podemos implementar qualquer algoritimo de iteração
        // como iterar em listas, matrizes, arvores, grafos etc...
        public Car GetNext()
        {
            return HasNext() ? _carList[_index++] : null;
        }

        public void Add(IList<Car> objects)
        {
            _carList = objects;
        }
    }
}

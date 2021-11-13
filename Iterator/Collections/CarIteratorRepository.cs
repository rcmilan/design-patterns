using Domain.Models;
using Iterator.Container;
using Iterator.Interfaces;
using Iterator.Iterators;
using System;

namespace Iterator.Collections
{
    public class CarIteratorRepository : IterableCollection<Car, Guid>
    {
        // repository apenas para retornar uma nova instancia do iterator
        public IIteratable<Car, Guid> GetIterator()
        {
            return new CarIterator();
        }
    }
}

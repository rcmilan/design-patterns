using Domain.Base;
using Iterator.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Iterator.Iterators
{
    public class ConcreteIterator<T, Id> : IIteratable<T, Id> where T : BaseModel<Id>
    {
        private int _index;
        private IList<T> _list;

        public ConcreteIterator()
        {
            _list = new List<T>();
        }

        public bool HasNext()
        {
            return _index < _list.Count;
        }

        // Podemos implementar qualquer algoritimo de iteração
        // como iterar em listas, matrizes, arvores, grafos etc...
        public T GetNext()
        {
            return HasNext() ? _list[_index++] : null;
        }

        public void Add(IList<T> objects)
        {
            _list = objects;
        }

        public List<T> GetOrdered()
        {
            return _list
                .OrderBy(l => l.Id)
                .ToList();
        }
    }
}

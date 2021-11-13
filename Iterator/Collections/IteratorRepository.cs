using Domain.Base;
using Iterator.Container;
using Iterator.Interfaces;
using Iterator.Iterators;

namespace Iterator.Collections
{
    public class IteratorRepository<T, Id> : IterableCollection<T, Id> where T : BaseModel<Id>
    {
        // repository apenas para retornar uma nova instancia do iterator
        public IIteratable<T, Id> GetIterator()
        {
            return new ConcreteIterator<T, Id>();
        }
    }
}

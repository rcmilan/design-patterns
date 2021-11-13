using Domain.Base;
using Iterator.Interfaces;

namespace Iterator.Container
{
    // pode retornar diferentes iterators
    public interface IterableCollection<T, Id> where T : BaseModel<Id>
    {
        public IIteratable<T, Id> GetIterator();
    }
}

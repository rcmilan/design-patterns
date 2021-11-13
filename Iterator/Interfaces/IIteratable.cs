using Domain.Base;
using System.Collections.Generic;

namespace Iterator.Interfaces
{
    // declara as funções para percorrer a estrutura de dados
    public interface IIteratable<T, Id> where T : BaseModel<Id>
    {
        public bool HasNext();
        public T GetNext();
        void Add(IList<T> objects);
    }
}

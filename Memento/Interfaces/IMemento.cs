using Domain.Base;
using System;

namespace Memento.Interfaces
{
    public interface IMemento<T, Id> where T : BaseModel<Id>
    {
        T GetState();
        DateTime GetDate();
        string GetDescription();
    }
}

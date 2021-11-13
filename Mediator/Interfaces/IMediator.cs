using Domain.Base;

namespace Mediator.Interfaces
{
    public interface IMediator<T>
    {
        void Store(BaseModel<T> model);
        BaseModel<T> Read(BaseModel<T> model);
    }
}

using Domain.Models;

namespace State;

public interface IState
{
    void Update(Document document);
}
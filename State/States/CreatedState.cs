using Domain.Enums;
using Domain.Models;

namespace State.States;

public class CreatedState : IState
{
    public void Update(Document document)
    {
        document.Title = "Created";
        document.Content = "aaaaaaaaaaaaaaaaaaaa";
        document.Step = Step.Created;
    }
}

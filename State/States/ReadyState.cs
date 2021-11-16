using Domain.Enums;
using Domain.Models;

namespace State.States;

public class ReadyState : IState
{
    public void Update(Document document)
    {
        document.Title = "Ready";
        document.Content = "1";
        document.Step = Step.Ready;
    }
}
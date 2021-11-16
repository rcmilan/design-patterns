using Observer.Subjects;

namespace Observer.Observers;

public class ConcreteObserverA : IObserver
{
    public void Update(ISubscriber subject)
    {
        if ((subject as Subscriber).state.FirstName == "Observer")
        {
            // faz alguma coisa
        }
    }
}
using Observer.Subjects;

namespace Observer.Observers;

public class ConcreteObserver1 : IObserver
{
    public void Update(ISubscriber subject)
    {
        if ((subject as Subscriber).state != null)
        {
            // faz alguma coisa
        }
    }
}
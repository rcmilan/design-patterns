using Domain.Models;
using Observer.Observers;

namespace Observer.Subjects;

public class Subscriber : ISubscriber
{
    public Person state { get; set; }

    // lista de observers associados ao state
    private List<IObserver> _observers = new();

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(this);
        }
    }

    // Subscribers tem alguma lógica importante
    // Subscriber avisa os observers na execução dessa lógica
    public Person DoSomething()
    {
        state = state ?? new Person();

        state.FirstName = "Observer";
        state.LastName = "Person";

        Notify();

        return state;
    }
}
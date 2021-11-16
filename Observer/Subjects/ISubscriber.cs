using Observer.Observers;

namespace Observer.Subjects;

public interface ISubscriber
{
    // Associa o Observer ao Subject.
    void Subscribe(IObserver observer);

    // Remove um Observer do Subject.
    void Unsubscribe(IObserver observer);

    // Avisa todos os Observers
    void Notify();
}
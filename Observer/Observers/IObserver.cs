using Observer.Subjects;

namespace Observer.Observers;

public interface IObserver
{
    // Recebe atualizações do subject
    void Update(ISubscriber subject);
}
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Observer.Observers;
using Observer.Subjects;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ObserverController : ControllerBase
    {
        [HttpGet]
        public Person Get()
        {
            var subscriber = new Subscriber();

            var observerA = new ConcreteObserverA();
            subscriber.Subscribe(observerA);

            var observer1 = new ConcreteObserver1();
            subscriber.Subscribe(observer1);

            // faz alguma coisa e avisa os subscribers
            subscriber.DoSomething();

            subscriber.Unsubscribe(observerA);

            // faz alguma coisa e avisa os subscribers
            return subscriber.DoSomething();
        }
    }
}

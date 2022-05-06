using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public abstract class Subscriber : IObserver<int>
    {
        public IDisposable Subscription { get; set; }

        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name}: OnCompleted");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: Rezygnuje z subskrypcji");
            Subscription.Dispose();
            Subscription = null;
        }

        public abstract void OnNext(int value);
    }
}

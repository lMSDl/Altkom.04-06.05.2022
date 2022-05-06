using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class Publisher : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _subscribers = new List<IObserver<int>>();

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _subscribers.Add(observer);
            return new Unsubscribe(() => _subscribers.Remove(observer));
        }

        public void Calculate()
        {
            Console.WriteLine($"Rozpoczynam obliczenia...");
            Thread.Sleep(1000);

            int value = new Random().Next(-1, 10);
            Console.WriteLine($"Wynik obliczeń: {value}");
            _ = Task.Run(() => Notify(value));
        }

        private void Notify(int value)
        {
            if(value < 0)
            {
                _subscribers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException(value.ToString())));
            }
            else
            {
                _subscribers.ToList().ForEach(x => x.OnNext(value));
            }
        }

        public void Dispose()
        {
            _subscribers.ToList().ForEach(x => x.OnCompleted());
            _subscribers = null;
        }

        public class Unsubscribe : IDisposable
        {
            private Action _action;

            public Unsubscribe(Action action)
            {
                _action = action;
            }

            public void Dispose()
            {
                _action();
            }
        }
    }
}

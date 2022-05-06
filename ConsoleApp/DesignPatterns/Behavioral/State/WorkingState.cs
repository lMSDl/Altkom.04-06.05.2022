using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource cancellationTokenSource;
        public WorkingState(int time)
        {
            cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(TimeSpan.FromSeconds(time), cancellationTokenSource.Token).ContinueWith(x =>
            {
                CoffeeMachine.TransitionTo(new IdleState());
                cancellationTokenSource.Dispose();
            });
        }

        public override void LargeCoffee()
        {
            cancellationTokenSource.Cancel();
            System.Console.WriteLine("Anulowanie zdania");
        }

        public override void SmallCoffee()
        {
            LargeCoffee();
        }
    }
}
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    public class HeatingUpState : State
    {
        public HeatingUpState()
        {
            var task = Task.Delay(System.TimeSpan.FromSeconds(5));
            task.ContinueWith(x => CoffeeMachine.TransitionTo(new IdleState()));
        }

        public override void LargeCoffee()
        {
            System.Console.WriteLine("Rozgrzewam się, spróbuj później...");
        }

        public override void SmallCoffee()
        {
            LargeCoffee();
        }
    }
}
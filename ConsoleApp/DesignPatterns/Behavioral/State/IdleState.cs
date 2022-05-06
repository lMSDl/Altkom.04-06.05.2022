namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    public class IdleState : State
    {
        public override void LargeCoffee()
        {
            CoffeeMachine.TransitionTo(new WorkingState(7));
        }

        public override void SmallCoffee()
        {
            CoffeeMachine.TransitionTo(new WorkingState(4));
        }
    }
}
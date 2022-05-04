namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorUp : IElevatorOperation
    {
        public void Operate(int floor)
        {
            System.Console.WriteLine($"Winda zatrzyma się na piętrze {floor} jadąc w górę");
        }
    }
}
namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorDown : IElevatorOperation
    {
        public void Operate(int floor)
        {
            System.Console.WriteLine($"Winda zatrzyma się na piętrze {floor} jadąc w dół");
        }
    }
}
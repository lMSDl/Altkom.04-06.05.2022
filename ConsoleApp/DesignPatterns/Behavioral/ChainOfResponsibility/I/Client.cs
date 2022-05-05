namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class Client
    {
        public static void Execute()
        {
            var handler4 = new DiscountHandler(500, 4500, null) { Name = "4" };
            var handler3 = new DiscountHandler(500, 5000, handler4) { Name = "3" };
            var handler2 = new DiscountHandler(300, 5000, handler3) { Name = "2" };
            var handler1 = new DiscountHandler(100, 10000, handler2) { Name = "1" };


            handler1.Discount(250, 3000);
            handler1.Discount(300, 7000);
        }
    }
}

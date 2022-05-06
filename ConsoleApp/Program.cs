using ConsoleApp.SOLID.L;
using DesignPrinciples;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Behavioral.Iterator.Client.Execute();
        }

        private static void LSP()
        {
            Rectangle shape = new Square();

            var a = 4;
            var b = 6;

            Fill(shape, a, b);

            Console.WriteLine($"{a}*{b}=");
            ShowArea(shape);
        }

        static void Fill(Rectangle rectangle, int a, int b)
        {
            rectangle.A = a;
            rectangle.B = b;
        }

        static void ShowArea(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Area);
        }

        private static void DesignPrinciples()
        {
            var customersService = new CustomersService();
            var paymentService = new PaymentService();

            var customer = customersService.FindById(1);
            paymentService.Charge(customer.PaymentAccount, 100);
        }
    }
}

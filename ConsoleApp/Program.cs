using DesignPrinciples;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customersService = new CustomersService();
            var paymentService = new PaymentService();

            var customer = customersService.FindById(1);
            paymentService.Charge(customer.PaymentAccount, 100);


        }
    }
}

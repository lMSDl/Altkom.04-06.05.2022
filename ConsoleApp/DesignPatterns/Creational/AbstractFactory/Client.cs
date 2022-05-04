using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public static void Execute()
        {
            Order order;
            Console.WriteLine("\r\n------------This is HONDA Car Factory----------------");
            order = new Order(new HondaFactory(), "sedan", "compact");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as compact Sedan");

            order = new Order(new HondaFactory(), "suv", "full");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as full Suv");

            Console.WriteLine("\r\n\r\n------------This is TOYOTA Car Factory----------------");
            order = new Order(new ToyotaFactory(), "suv", "compact");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as compact Suv");

            order = new Order(new ToyotaFactory(), "sedan", "full");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as full Sedan");
            Console.ReadLine();
        }
    }
}

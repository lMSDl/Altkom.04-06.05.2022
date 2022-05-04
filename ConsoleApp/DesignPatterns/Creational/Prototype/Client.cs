using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            var p1 = new Person
            {
                Age = 23,
                Name = "Adam Adamski",
                IdInfo = new IdInfo(),
                Addresses = new List<string> { "Warszawa, Krakówska 12" }
            };

            Console.WriteLine(p1);

            var p2 = (Person)p1.Clone();
            p2.Name = "Ewa Ewowska";
            p2.Addresses.Clear();
            p2.Addresses.Add("Kraków, Warszawska 21");
            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}

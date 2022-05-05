using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {

            var person = new Person { Name = "Ala Alowska", BirthDate = DateTime.Now };

            var json = ServiceFacade.ToJson(person);

            Service(json);

        }


        static void Service(string  json)
        {
            Console.WriteLine(json);
        }
    }
}

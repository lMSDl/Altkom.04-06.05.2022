using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Memento
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person() { Name = "Tomasz Tomaszewski", BirtDate = DateTime.Now.AddYears(-35) };
            
            var caretaker = new Caretaker<Person>(person);
            caretaker.SaveState();
            Console.WriteLine(person);

            Thread.Sleep(1000);
            person.Name = "Monika Monikowska";
            caretaker.SaveState();
            Console.WriteLine(person);


            Thread.Sleep(1000);
            person.BirtDate = DateTime.Now.AddYears(-65);
            caretaker.SaveState();
            Console.WriteLine(person);

            Thread.Sleep(1000);
            person.ResetId();
            Console.WriteLine(person);

            caretaker.Undo();
            Console.WriteLine(person);

            Thread.Sleep(1000);
            person.ResetId();
            caretaker.SaveState();
            Console.WriteLine(person);


            caretaker.Undo(DateTime.Now.AddSeconds(-3));
            Console.WriteLine(person);

            caretaker.Undo(DateTime.Now);
            Console.WriteLine(person);
        }
    }
}

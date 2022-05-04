using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 5;
            elevator.Execute(action, floor);


             action = "Up";
             floor = 2;
            elevator.Execute(action, floor);
        }
    }
}

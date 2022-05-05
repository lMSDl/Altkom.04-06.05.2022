using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            var circle = new Circle();
            Console.WriteLine(circle);
             circle = new Circle() { Color = new Red() };
            Console.WriteLine(circle);
             circle = new Circle() { Color = new Blue()};
            Console.WriteLine(circle);
        }
        }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.I
{
    public class Client
    {
        public static void Execute()
        {
            var circle = new Circle() { Radius = 4 };
            var square = new Square() { Width = 8 };

            Console.WriteLine(Check(circle));
            
            Console.WriteLine(Check(new SquareToCircleAdapter(square)));
        }

        private static bool Check(ICircle circle)
        {
            return circle.Radius <= 5;
        }
    }
}

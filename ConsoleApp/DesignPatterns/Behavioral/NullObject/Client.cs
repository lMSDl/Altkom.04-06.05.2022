using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.NullObject
{
    public class Client
    {
        public static void Execute()
        {
            var objects = new AbstractClass[] { new RealClass(), new NullClass(), null };

            while(true)
            {
                try
                {
                    Console.ReadLine();
                    var random = new Random().Next(0, 3);
                    objects[random]?.MethodA();
                    objects[random]?.MethodB();
                    objects[random]?.MethodC();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

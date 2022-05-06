using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.NullObject
{
    public abstract class AbstractClass
    {
        public void MethodA()
        {
            Console.WriteLine("A");
        }
        public void MethodB()
        {
            Console.WriteLine("B");
        }
        public abstract void MethodC();
    }
}

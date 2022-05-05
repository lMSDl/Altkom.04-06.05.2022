using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public class Coffee : Product
    {
        public Coffee(string name, float value) : base(name, value)
        {
        }
    }
}

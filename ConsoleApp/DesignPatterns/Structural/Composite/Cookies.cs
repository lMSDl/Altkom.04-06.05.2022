using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public class Cookies : Product
    {
        public Cookies(string name, float value) : base(name, value)
        {
        }
    }
}

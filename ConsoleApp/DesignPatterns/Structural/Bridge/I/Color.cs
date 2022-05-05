using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.I
{
    public abstract class Color
    {
        public override string ToString()
        {
            return $"{GetType().Name}";
        }
    }
}

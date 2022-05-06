using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.State
{
    public abstract class State
    {
        public CoffeeMachine CoffeeMachine { get; set; }

        public abstract void SmallCoffee();
        public abstract void LargeCoffee();
    }
}

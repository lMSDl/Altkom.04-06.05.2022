using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public abstract class Component
    {
        public Component Parent { get; set; }

        public void Click()
        {
            Click(false);
        }

        protected virtual void Click(bool handled)
        {
            if (Parent != null)
                Parent.Click(handled);
        }

    }
}

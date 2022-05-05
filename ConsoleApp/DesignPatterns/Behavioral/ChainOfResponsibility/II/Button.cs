using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Button : Component
    {
        public Func<bool> OnClick { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled)
            {
                var result = OnClick();
                base.Click(result);
            }
            else
            {
                base.Click(false);
            }
        }

    }
}

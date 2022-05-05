using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class BaseDiscountHandler : IDiscountHandler
    {
        private IDiscountHandler _next;

        public BaseDiscountHandler(IDiscountHandler next)
        {
            _next = next;
        }

        public virtual bool Discount(float value, float price)
        {
            if (_next != null)
                return _next.Discount(value, price);
            return false;
        }
    }
}

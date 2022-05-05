using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public interface IDiscountHandler
    {
        bool Discount(float value, float price);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Strategy
{
    public class MinusStrategy : ICalcStrategy
    {
        public float Calculate(float value1, float value2)
        {
            return value1 - value2;
        }
    }
}

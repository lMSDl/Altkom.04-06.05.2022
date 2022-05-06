using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Strategy
{
    public interface ICalcStrategy
    {
        float Calculate(float value1, float value2);
    }
}

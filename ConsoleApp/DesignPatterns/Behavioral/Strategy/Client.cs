using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calculator = new Calculator();

            while (true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calculator.Strategy = GetCalcStrategy(split[1]);

                if (float.TryParse(split[0], out float val1) && float.TryParse(split[2], out float val2))
                {
                    var result = calculator.Calc(val1, val2);
                    Console.WriteLine(result);

                    result = GetCalcFunc(split[1])(val1, val2);
                    Console.WriteLine(result);
                }
            }
        }

        private static ICalcStrategy GetCalcStrategy(string arg)
        {
            switch (arg)
            {
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
                case "+":
                    return new PlusStrategy();
                case "-":
                    return new MinusStrategy();
                default:
                    return null;
            }
        }

        private static Func<float, float, float> GetCalcFunc(string arg)
        {
            switch (arg)
            {
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                default:
                    return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public abstract class Product : IProduct, ICloneable
    {
        public string Name { get; }
        public float Value { get; }

        public Product(string name, float value)
        {
            Name = name;
            Value = value;
        }

        public float GetValue()
        {
            Console.WriteLine($"Wartość {Name}: {Value}");
            return Value;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}

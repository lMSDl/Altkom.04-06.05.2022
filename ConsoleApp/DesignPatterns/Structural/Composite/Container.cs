using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public abstract class Container : IProduct
    {
        public string Name { get; }
        public ICollection<IProduct> Products { get; } = new List<IProduct>();

        protected Container(string name)
        {
            Name = name;
        }

        public float GetValue()
        {
            var value = Products.Any() ? Products.Sum(x => x.GetValue()) : 0;
            Console.WriteLine($"Wartość kontenera {Name}: {value}");
            return value;
        }
    }
}

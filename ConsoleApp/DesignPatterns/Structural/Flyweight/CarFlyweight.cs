using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public class CarFlyweight
    {
        public string Manufacturer { get; }
        public string Model { get; }
        public string Color { get;  }

        public CarFlyweight()
        {
        }

        public CarFlyweight(string manufacturer, string model, string color)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
        }
    }
}

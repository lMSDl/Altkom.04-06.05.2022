using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public string Manufacturer { get => Flyweight.Manufacturer; set => Flyweight = new CarFlyweight(value, Model, Color); }
        public string Model { get => Flyweight.Model; set => Flyweight = new CarFlyweight(Manufacturer, value, Color); }
        public string Color { get => Flyweight.Color; set => Flyweight = new CarFlyweight(Manufacturer, Model, value); }

        public CarFlyweight Flyweight { get; set; } = new CarFlyweight();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public record RecordCarFlyweight
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public abstract class BaseVehicleBuilder
    {
        protected Vehicle Vehicle { get; set; }

        public BaseVehicleBuilder() : this(new Vehicle())
        {
        }
        public BaseVehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}

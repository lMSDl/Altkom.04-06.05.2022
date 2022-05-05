using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public class VehicleManufactureInfoBuilder : VehicleBuilderFacade
    {
        public VehicleManufactureInfoBuilder() : this(new Vehicle())
        {
        }

        public VehicleManufactureInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufactureInfoBuilder SetManufacturer(string value) { Vehicle.Manufacturer = value; return this; }
        public VehicleManufactureInfoBuilder SetDate(DateTime value) { Vehicle.Date = value; return this; }
        public VehicleManufactureInfoBuilder SetModel(string value) { Vehicle.Model = value; return this; }

    }
}

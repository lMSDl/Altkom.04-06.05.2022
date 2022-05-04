using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.AbstractFactory
{
    public class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory carFactory, string type, string segment)
        {
            switch(type)
            {
                case "sedan":
                    _car = carFactory.ManufactureSedan(segment);
                    break;
                case "suv":
                    _car = carFactory.ManufactureSuv(segment);
                    break;
            }
        }

        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}

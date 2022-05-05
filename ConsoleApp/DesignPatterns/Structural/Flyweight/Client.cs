using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory<CarFlyweight>(new[] {
                new CarFlyweight ( "Chevrolet",  "Camaro2018",  "Pink" ),
                new CarFlyweight (  "Mercedes Benz",  "C300",  "Black" ),
                new CarFlyweight (  "Mercedes Benz",  "C500",  "Red" ),
                new CarFlyweight (  "BMW",  "M5",  "Red" ),
                new CarFlyweight (  "BMW",  "X6",  "White" )
                });

            factory.Show();

            var car = new Car()
            {
                Number = "1238gda",
                Owner = "Agata Agatowska",
                Manufacturer = "Chevrolet",
                Color = "Pink",
                Model = "Camaro2018"
            };
            car.Flyweight = factory.GetFlyweight(car.Flyweight);


            var car2 = new Car()
            {
                Number = "789dwgfsyi",
                Owner = "Tymon Tymoszewski",
                Manufacturer = "BMW",
                Color = "White",
                Model = "C500"
            };
            car2.Flyweight = factory.GetFlyweight(car2.Flyweight);
            var car3 = new Car()
            {
                Number = "mns8e6",
                Owner = "Alicja Alicjowska",
                Manufacturer = "BMW",
                Color = "White",
                Model = "C500"
            };
            car3.Flyweight = factory.GetFlyweight(car3.Flyweight);

            factory.Show();

            car2.Color = "Black";
            car2.Flyweight = factory.GetFlyweight(car2.Flyweight);

            Console.WriteLine(JsonConvert.SerializeObject(car2));
            Console.WriteLine(JsonConvert.SerializeObject(car3));

        }
    }
}

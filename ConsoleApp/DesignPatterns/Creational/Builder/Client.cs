using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);
            Console.WriteLine(vehicle);
            
            var builder = new VehicleBuilder();
            builder.SetWheels(4);
            builder.SetSeats(5);
            builder.SetDoors(4);
            builder.SetEnginePower(100);
            builder.SetTrunkCapacity(500);
            vehicle = builder.Build();

            Console.WriteLine(vehicle);

            builder.SetDoors(2);
            vehicle = builder.Build();
            Console.WriteLine(vehicle);

            vehicle = new VehicleBuilder()
                        .SetWheels(4)
                        .SetSeats(5)
                        .SetDoors(4)
                        .SetEnginePower(100)
                        .SetTrunkCapacity(500)
                        .Build();

            Console.WriteLine(vehicle);

            vehicle = new Vehicle() { Wheels = 4 , Seats = 5, Doors = 4, EnginePower = 100, TrunkCapacity = 500 };

            Console.WriteLine(vehicle);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public void Execute(string action, int floor)
        {
            Execute(CreateOperation(action), floor);
        }
        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }

        public IElevatorOperation CreateOperation(string action)
        {
            if(_operations.TryGetValue(action, out var elevatorOperation))
            {
                return elevatorOperation;
            }

            switch (action)
            {
                case "Down":
                    elevatorOperation = new ElevatorDown();
                    break;
                case "Up":
                    elevatorOperation = new ElevatorUp();
                    break;
            }

            _operations[action] = elevatorOperation;

            return elevatorOperation;
        }
    }
}

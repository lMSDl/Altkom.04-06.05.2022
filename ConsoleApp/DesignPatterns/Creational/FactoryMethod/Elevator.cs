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

        public Elevator()
        {
            var type = typeof(IElevatorOperation);
            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));
        }

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
            return (IElevatorOperation)Activator.CreateInstance(Type.GetType($"{GetType().Namespace}.{nameof(Elevator)}{action}"));


            //if (_operations.TryGetValue(action, out var elevatorOperation))
            //{
            //    return elevatorOperation;
            //}

            //switch (action)
            //{
            //    case "Down":
            //        elevatorOperation = new ElevatorDown();
            //        break;
            //    case "Up":
            //        elevatorOperation = new ElevatorUp();
            //        break;
            //}

            //_operations[action] = elevatorOperation;

            //return elevatorOperation;
        }
    }
}

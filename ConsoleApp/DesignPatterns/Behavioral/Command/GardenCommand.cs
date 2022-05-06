using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class GardenCommand : ICommand
    {
        private Garden _receiver;
        private GardenActions _action;
        private string _plantName;

        public GardenCommand(Garden receiver, GardenActions action, string plantName)
        {
            _receiver = receiver;
            _action = action;
            _plantName = plantName;
        }

        public bool Execute()
        {
            switch (_action)
            {
                case GardenActions.Plant:
                    return _receiver.Plant(_plantName);

                case GardenActions.Remove:
                    return _receiver.Remove(_plantName);
            }
            return false;
        }

        public void Undo()
        {
            switch (_action)
            {
                case GardenActions.Plant:
                    _receiver.Remove(_plantName);
                    break;

                case GardenActions.Remove:
                    _receiver.Plant(_plantName);
                    break;
            }
        }
    }
}

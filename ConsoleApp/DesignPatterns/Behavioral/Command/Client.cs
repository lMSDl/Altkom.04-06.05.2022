using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);

            var plantTreeCommand = new GardenCommand(garden, GardenActions.Plant, "tree");
            var plantFlowersCommand = new GardenCommand(garden, GardenActions.Plant, "flowers");

            var plantTreeButton = new CommandInvoker(plantTreeCommand);
            var plantFowersButton = new CommandInvoker(plantFlowersCommand);


            Console.WriteLine(garden);

            plantFowersButton.Invoke();
            plantFowersButton.Invoke();
            Console.WriteLine(garden);
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            Console.WriteLine(garden);

            CommandInvoker.Undo();
            Console.WriteLine(garden);

            plantFowersButton.Invoke();
            plantFowersButton.Invoke();
            Console.WriteLine(garden);

            CommandInvoker.Undo();
            CommandInvoker.Undo();
            CommandInvoker.Undo();
            Console.WriteLine(garden);

        }
    }
}

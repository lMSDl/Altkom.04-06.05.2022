using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class CommandInvoker
    {
        private static readonly Stack<ICommand> _commandsStack = new Stack<ICommand>();
        private ICommand _command;


        public CommandInvoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if(_command.Execute())
                _commandsStack.Push(_command);
        }

        public static void Undo()
        {
            if (!_commandsStack.Any())
                return;
            var command = _commandsStack.Pop();
            command.Undo();
        }
    }
}

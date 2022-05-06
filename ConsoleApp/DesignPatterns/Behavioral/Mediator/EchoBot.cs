using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public class EchoBot : ChatMember
    {
        public EchoBot(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Chat.Notify(new ChatMediatorParameters { From = Nick, To = from, Message = message });
            else
                Chat.Notify(new ChatMediatorParameters { From = Nick, Message = message });
        }
    }
}

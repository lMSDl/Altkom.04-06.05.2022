using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatMember
    {
        public string Nick { get; }
        public IMediator<ChatMediatorParameters> Chat { get; set; }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public virtual void Send(string message)
        {
            Chat.Notify(new ChatMediatorParameters { From = Nick, Message = message });
        }

        public virtual void Send(string to, string message)
        {
            Chat.Notify(new ChatMediatorParameters { From = Nick, To = to, Message = message });
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}

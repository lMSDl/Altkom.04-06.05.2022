using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public class Chat : IMediator<ChatMediatorParameters>
    {
        private ICollection<ChatMember> _chatMembers = new List<ChatMember>();

        public void Join(ChatMember member)
        {
            _chatMembers.Add(member);
            member.Chat = this;
        }

        public void Notify(ChatMediatorParameters parameters)
        {
            if(string.IsNullOrWhiteSpace(parameters.To))
            {
                HandlePublicMessage(parameters.From, parameters.Message);
            }
            else
            {
                HandlePrivateMessage(parameters.From, parameters.To, parameters.Message);
            }
        }

        private void HandlePrivateMessage(string from, string to, string message)
        {
            _chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }

        private void HandlePublicMessage(string from, string message)
        {
            var query = _chatMembers.Where(x => x.Nick != from);
            if (_chatMembers.SingleOrDefault(x => x.Nick == from) is EchoBot)
            {
                query = query.Where(x => !(x is EchoBot));
            }

            foreach (var item in query)
            {
                item.Receive(from, message, false);
            }    
        }
    }
}

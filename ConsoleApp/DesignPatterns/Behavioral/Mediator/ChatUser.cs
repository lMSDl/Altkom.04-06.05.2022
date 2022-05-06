using System;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public class ChatUser : ChatMember
    {
        private readonly string _format = "{0}: {1}";

        public ChatUser(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Console.WriteLine($"*{_format}*", from, message);
            else
                Console.WriteLine(_format, from, message);
        }
    }
}

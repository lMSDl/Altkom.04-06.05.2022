using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.II
{
    public class SmsGate : IMessageSenderImplementation
    {
        public const int MAX_LENGTH = 10;
        public void SendMessage(string message)
        {
            foreach (var item in Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MAX_LENGTH))
                .Select(x => message.Substring(x * MAX_LENGTH, Math.Min(MAX_LENGTH, message.Length - x * MAX_LENGTH))))
            {
                Console.WriteLine($"Sms: {item}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            var text = Console.ReadLine();
            MessageAbstraction message = new MessageAbstraction(new SmsGate());
            message.Send(text);
            message = new MessageAbstraction(new EmailGate());
            message.Send(text);

            message = new ShortMessageAbstraction(new SmsGate());
            message.Send(text);
            message = new ShortMessageAbstraction(new EmailGate());
            message.Send(text);
        }
        }
    }

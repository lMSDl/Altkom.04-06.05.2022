using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Decorator
{
    public class SmsNotification : BaseNotificationDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        protected override void DecoratorSend(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
}

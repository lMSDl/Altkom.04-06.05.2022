using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Decorator
{
    public abstract class BaseNotificationDecorator : INotification
    {
        private readonly INotification _notification;

        public BaseNotificationDecorator(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string message)
        {
            _notification.Send(message);
            DecoratorSend(message);
        }

        protected abstract void DecoratorSend(string message);
    }
}

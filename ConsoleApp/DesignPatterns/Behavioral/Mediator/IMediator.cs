using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator
{
    public interface IMediator<T>
    {
        void Notify(T parameters);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Memento
{
    public interface IRestorable<T>
    {
        void Restore(T state);
    }
}

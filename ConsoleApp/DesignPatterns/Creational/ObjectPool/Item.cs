using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.ObjectPool
{
    public class Item
    {
        public bool IsVisible { get; set; }

        public byte[] Content { get; } = new byte[10240];
    }
}

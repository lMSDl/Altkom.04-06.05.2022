using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class OddSubscriber : Subscriber
    {
        public override void OnNext(int value)
        {
            if(value % 2 != 0)
            {
                Console.WriteLine("OddSubscriber reaguje na dane");
                Thread.Sleep(5000);
            }
        }
    }
}

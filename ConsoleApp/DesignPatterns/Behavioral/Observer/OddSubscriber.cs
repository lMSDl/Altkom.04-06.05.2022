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
        public async override void OnNext(int value)
        {
            await Task.Yield();
            if(value % 2 != 0)
            {
                Thread.Sleep(5000);
                Console.WriteLine("OddSubscriber reaguje na dane");
            }
        }
    }
}

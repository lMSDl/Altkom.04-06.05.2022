using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class ThirdSubscriber : Subscriber
    {
        public override void OnNext(int value)
        {
            if(value % 3 == 0)
            {
                Console.WriteLine("ThirdSubscriber reaguje na dane");
            }
        }
    }
}

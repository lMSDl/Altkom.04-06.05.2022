using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            var subA = new OddSubscriber();
            var subB = new ThirdSubscriber();

            using (var emiter = new Publisher())
            {
                subA.Subscription = emiter.Subscribe(subA);
                subB.Subscription = emiter.Subscribe(subB);

                emiter.Calculate();
                emiter.Calculate();
                emiter.Calculate();
                if (subA.Subscription == null)
                    subA.Subscription = emiter.Subscribe(subA);
                emiter.Calculate();
                emiter.Calculate();
            }

            Console.ReadLine();
        }
    }
}

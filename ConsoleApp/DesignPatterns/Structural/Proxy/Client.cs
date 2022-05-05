using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            IDatabase database = new SmartConnectionLimitProxy( new Database() );

            for (int i = 0; i < 10; i++)
            {
                _ = database.RequestAsync(i);
            }
            Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                _ = database.RequestAsync(i);
            }
            Console.ReadLine();
        }
    }
}

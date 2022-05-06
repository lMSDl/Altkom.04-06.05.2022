using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };

            //var buffer = list.First();
            //for (int i = 1; i < list.Count; i++)
            //{
            //    Console.WriteLine(buffer + list[i]);
            //    buffer = list[i];
            //}

            var buffer = new Buffer<string>(list);
            var enumerator = buffer.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item.Item1 + item.Item2);
            }

            foreach (var item in buffer)
            {
                Console.WriteLine(item.Item1 + item.Item2);
            }
        }
    }
}

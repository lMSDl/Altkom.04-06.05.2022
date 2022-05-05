using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            //var counter = 1000;
            //while(true)
            //{
            //    if(counter == 0)
            //    {
            //        Thread.Sleep(10);
            //        continue;
            //    }

            //    var item = new Item { IsVisible = true };

            //    Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; Interlocked.Increment(ref counter); });
            //    Interlocked.Decrement(ref counter);
            //}

            //var objctPool = new ObjectPool<Item>(1000, () => new Item());
            //while (true)
            //{
            //    var item = objctPool.Acquire();
            //    if (item == null)
            //    {
            //        Thread.Sleep(10);
            //        continue;
            //    }

            //    item.IsVisible = true;

            //    Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; objctPool.Release(item); });
            //}

            var itemPool = new ItemPool<Item>(1000, () => new Item(), x => !x.IsVisible, x => x.IsVisible = true);
            while (true)
            {
                var item = itemPool.Acquire();
                if (item == null)
                {
                    Thread.Sleep(10);
                    continue;
                }

                Task.Delay(1000).ContinueWith(x => item.IsVisible = false );
            }
        }
    }
}

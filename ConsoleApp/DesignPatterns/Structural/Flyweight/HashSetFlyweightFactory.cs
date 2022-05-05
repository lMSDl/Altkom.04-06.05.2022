using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public class HashSetFlyweightFactory<T>
    {
        private readonly HashSet<T> _cache;

        public HashSetFlyweightFactory() : this(Enumerable.Empty<T>())
        {
        }
        public HashSetFlyweightFactory(IEnumerable<T> init)
        {
            _cache = new HashSet<T>(init);
        }

        public T GetFlyweight(T item)
        {
            if(_cache.TryGetValue(item, out var flyweight))
            {
                Console.WriteLine($"Zwracanie z cache");
                return flyweight;
            }

            Console.WriteLine($"Dodawanie do cache");
            _cache.Add(item);
            return item;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory<T>
    {
        private readonly Dictionary<string, T> _cache;

        public FlyweightFactory() : this(Enumerable.Empty<T>())
        {
        }
        public FlyweightFactory(IEnumerable<T> init)
        {
            _cache = init.ToDictionary(GetKey);
        }

        private string GetKey(T item)
        {
            return JsonConvert.SerializeObject(item);
        }

        public T GetFlyweight(T item)
        {
            var key = GetKey(item);

            if(_cache.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine($"Zwracanie z cache: {key}");
                return flyweight;
            }

            Console.WriteLine($"Dodawanie do cache: {key}");
            _cache[key] = item;
            return item;
        }

        public void Show()
        {
            Console.WriteLine($"Count: {_cache.Count}");
            foreach (var item in _cache)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}

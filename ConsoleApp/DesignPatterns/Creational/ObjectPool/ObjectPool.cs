using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.ObjectPool
{
    public class ObjectPool<T>
    {
        private ConcurrentStack<T> _pool = new ConcurrentStack<T>();

        public ObjectPool(int size, Func<T> func)
        {
            for (int i = 0; i < size; i++)
            {
                _pool.Push(func());
            }
        }

        public T Acquire()
        {
            if (_pool.TryPop(out var item))
                return item;
            return default(T);
        }

        public void Release(T item)
        {
            _pool.Push(item);
        }
    }
}

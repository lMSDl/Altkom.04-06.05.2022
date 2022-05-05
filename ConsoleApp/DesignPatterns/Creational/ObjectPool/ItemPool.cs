using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.ObjectPool
{
    public class ItemPool<T>
    {
        private ICollection<T> _pool = new List<T>();
        private Func<T, bool> _check;
        private Action<T> _chageState;
        public ItemPool(int size, Func<T> create, Func<T, bool> check, Action<T> changeState)
        {
            for (int i = 0; i < size; i++)
            {
                _pool.Add(create());
            }
            _chageState = changeState;
            _check = check;
        }

        public T Acquire()
        {
            var item = _pool.FirstOrDefault(x => _check(x));
            if (item == null)
                return default(T);

            _chageState(item);
            return item;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Iterator
{
    public class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {

        public Tuple<T, T> Current { get; private set; }
        private IEnumerator<T> _enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator.Dispose();
            _enumerator = null;
            Current = null;
        }

        public bool MoveNext()
        {
            var item = _enumerator.Current;
            if(_enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(item, _enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            _enumerator.MoveNext();
            Current = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private readonly ICollection<Memento<T>> _mementos = new List<Memento<T>>();
        private T _originator;

        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void SaveState()
        {
            Console.WriteLine($" {DateTime.Now}: Zapisywanie stanu");
            _mementos.Add(new Memento<T>((T)_originator.Clone()));
        }

        public void Undo()
        {
            if (!_mementos.Any())
                return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"Prywracanie stanu z {memento.DateTime}");

            _originator.Restore(memento.State);
        }

        public void Undo(DateTime dateTime)
        {
            var memento = _mementos.OrderBy(x => x.DateTime).LastOrDefault(x => x.DateTime <= dateTime);
            if(memento != null)
               _originator.Restore(memento.State);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder("Lista pamiątek:\n");
            foreach (var item in _mementos)
            {
                stringBuilder.AppendLine(item.DateTime.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}

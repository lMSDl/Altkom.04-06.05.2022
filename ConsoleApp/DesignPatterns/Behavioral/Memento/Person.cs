using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Memento
{
    public class Person : ICloneable, IRestorable<Person>
    {
        public DateTime BirtDate { get; set; }
        public string Name { get; set; }
        private Guid _id;

        public Person()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }

        public void ResetId()
        {
            _id = Guid.NewGuid();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            //BirtDate = state.BirtDate;
            //Name = state.Name;
            //_id = state._id;

            foreach (var property in GetType().GetProperties().Where(x => x.CanWrite))
            {
                var value = property.GetValue(state);
                property.SetValue(this, value);
            }
            foreach (var field in GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var value = field.GetValue(state);
                field.SetValue(this, value);
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this) + $" {GetId().ToString()}";
        }
    }
}

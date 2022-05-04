using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Addresses { get; set; }
        public IdInfo IdInfo { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Addresses = new List<string>(Addresses); /*Addresses.Select(x => (string)x.Clone()).ToList();*/
            //clone.IdInfo = (IdInfo)IdInfo.Clone();
            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

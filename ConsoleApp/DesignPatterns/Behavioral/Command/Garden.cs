using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class Garden
    {
        public int Size { get; }
        private List<string> Plants { get; } = new List<string>();

        public Garden(int size)
        {
            Size = size;
        }

        public bool Plant(string name)
        {
            if(Plants.Count < Size)
            {
                Console.WriteLine($"Sadzenie {name}");
                Plants.Add(name);
                return true;
            }

            Console.WriteLine($"Brak miejsca w ogrodzie dla {name}");
            return false;
        }

        public bool Remove(string name)
        {
            if(Plants.Any(x => x == name))
            {
                Console.WriteLine($"Usuwanie {name}");
                Plants.Remove(name);
                return true;
            }

            Console.WriteLine($"W ogorodzie nie ma {name}");
            return false;
        }

        public override string ToString()
        {
            Console.WriteLine();
            foreach (var item in Plants)
            {
                Console.WriteLine(item);
            }
            return $"W ogordzie jest {Plants.Count} roślin";
        }
    }
}

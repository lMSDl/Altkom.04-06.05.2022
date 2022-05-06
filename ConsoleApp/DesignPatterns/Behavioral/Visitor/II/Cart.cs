using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.II
{
    public class Cart : Basket
    {
        public override void Add(Product product)
        {
            Console.WriteLine("Produkt jest w wózku");
        }
        public override void Add(BoxedProduct product)
        {
            Console.WriteLine("Zgrzewka w wózku");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Composite
{
    public class Client
    {
        public static void Execute()
        {
            var cookies = new Cookies("Oreo", 15);
            var coffee = new Coffee("Lavazza", 30);
            var tea = new Tea("Lipton", 10);


            var hall = new Hall("Hala 1");
            var shelf1 = new Shelf("Regał 1");
            var shelf2 = new Shelf("Regał 2");
            var shelf3 = new Shelf("Regał 3");

            var box1 = new Box("pudło duże");
            var box2 = new Box("pudło małe");

            hall.Products.Add(shelf1);
            hall.Products.Add(shelf2);
            hall.Products.Add(shelf3);
            hall.Products.Add(box1);
            shelf2.Products.Add(box2);

            for (int i = 0; i < 5; i++)
            {
                box2.Products.Add((IProduct)tea.Clone());
            }
            for (int i = 0; i < 5; i++)
            {
                box1.Products.Add((IProduct)coffee.Clone());
                box1.Products.Add((IProduct)cookies.Clone());
            }
            for (int i = 0; i < 2; i++)
            {
                shelf3.Products.Add((IProduct)tea.Clone());
                shelf3.Products.Add((IProduct)cookies.Clone());
            }


            hall.GetValue();

            box1.GetValue();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.I
{
    public class Client
    {
        public static void Execute()
        {
            PlainText element1 = new PlainText() { Text = "plain" };
            PlainText element2 = new PlainText() { Text = "\n" };
            BoldText element3 = new BoldText() { Bold = "bold" };
            Hyperlink element4 = new Hyperlink() { Url = "http:\\\\some.url.com", Label = "SomeUrl Company" };

            IEnumerable<IElement> elements = new IElement[] { element1, element2, element3, element2, element4 };

            var htmlVisitor = new HtmlVisitor();
            foreach (var item in elements)
            {
                item.Accept(htmlVisitor);
            }
            Console.WriteLine(htmlVisitor);
        }
    }
}

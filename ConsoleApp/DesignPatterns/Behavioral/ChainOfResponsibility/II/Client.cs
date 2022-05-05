using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Client
    {
        public static void Execute()
        {
            var frame = new Frame();
            var textBox = new TextBox();
            frame.Add(textBox);
            var button = new Button();
            textBox.Add(button);

            button.OnClick = () =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return false;
                textBox.Text = null;
                Console.WriteLine("Button: TextBox clear");
                return true;
            };

            Console.WriteLine("frame.Click()");
            frame.Click();
            Console.WriteLine("textBox.Click()");
            textBox.Click();
            Console.WriteLine("button.Click()");
            button.Click();

            textBox.Text = "abc";
            Console.WriteLine("button.Click()");
            button.Click();
            Console.WriteLine("button.Click()");
            button.Click();

        }
    }
}

using System;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class TextBox : Container
    {
        private string text;

        public string Text
        {
            get => text;
            set
            {
                text = value;
                Console.WriteLine($"TextBox: {value}");
            }
        }

        protected override void Click(bool handled)
        {
            if (!handled)
            {
                Console.WriteLine($"TextBox: focus");
                base.Click(true);
            }
            else
            {
                base.Click(false);
            }
        }

    }
}

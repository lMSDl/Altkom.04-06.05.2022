using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger<string, IDisposable>
    {
        protected override void SaveData(string data, IDisposable service)
        {
            Console.WriteLine("Sending Email with Log Message : " + data);
        }

        protected override IDisposable GetService()
        {
            return null;
        }

        protected override string PrepareData(string message)
        {
            Console.WriteLine("Serializing message");
            return $"Email: {message}";
        }
    }
}

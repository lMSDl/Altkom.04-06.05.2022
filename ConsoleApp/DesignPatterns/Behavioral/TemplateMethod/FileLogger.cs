using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : Logger<string, FileService>
    {
        protected override void AfterServiceDispose()
        {
            Console.WriteLine("Close File.");
        }

        protected override void SaveData(string data, FileService service)
        {
            Console.WriteLine("Appending Log message to file : " + data);
        }

        protected override FileService GetService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }

        protected override string PrepareData(string message)
        {
            Console.WriteLine("Serializing message");
            return $"{DateTime.Now}: {message}";
        }
    }
}

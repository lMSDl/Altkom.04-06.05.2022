using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<LoggerEntity, DbService>
    {
        protected override void BeforeServiceDispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        protected override void SaveData(LoggerEntity data, DbService service)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + data.Message);
        }

        protected override DbService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DbService();
        }

        protected override LoggerEntity PrepareData(string message)
        {
            Console.WriteLine("Serializing message");
            return new LoggerEntity { DateTime = DateTime.Now, Message = message };
        }
    }
}

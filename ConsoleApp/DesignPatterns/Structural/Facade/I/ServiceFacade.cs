using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.I
{
    public static class ServiceFacade
    {
        private static JsonSerializerSettings _settings = new JsonSerializerSettings()
        {
            DateFormatString = "yyyy_MMM+dd"
        };

        public static string ToJson<T>(T item)
        {
            return JsonConvert.SerializeObject(item, _settings);
        }
    }
}

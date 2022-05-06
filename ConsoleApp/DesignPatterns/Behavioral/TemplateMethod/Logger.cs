using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Logger<TModel, TService> where TService : IDisposable
    {

        public void Log(string message)
        {
            TModel data = PrepareData(message);
            using (TService service = GetService())
            {
            //TService service = GetService();
                SaveData(data, service);
                BeforeServiceDispose();
            //service.Dispose();
            }
            AfterServiceDispose();

        }

        protected virtual void BeforeServiceDispose()
        {
        }

        protected virtual void AfterServiceDispose()
        {
        }

        protected abstract void SaveData(TModel data, TService service);
        protected abstract TService GetService();
        protected abstract TModel PrepareData(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Proxy
{
    public class SmartConnectionLimitProxy : IDatabase
    {
        private const int SemaphoreSlimCount = 3;
        private Database database;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(SemaphoreSlimCount);

        public SmartConnectionLimitProxy(Database database)
        {
            this.database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (database == null)
                database = new Database();

            await semaphoreSlim.WaitAsync();

            var result = await database.RequestAsync(parameter);

            semaphoreSlim.Release();

            if(semaphoreSlim.CurrentCount == SemaphoreSlimCount)
            {
                database.Dispose();
                database = null;
            }

            return result;
        }
    }
}

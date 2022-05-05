using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Proxy
{
    public class ConnectionLimitProxy : IDatabase
    {
        private IDatabase database;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);

        public ConnectionLimitProxy(IDatabase database)
        {
            this.database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            await semaphoreSlim.WaitAsync();

            var result = await database.RequestAsync(parameter);

            semaphoreSlim.Release();

            return result;
        }
    }
}

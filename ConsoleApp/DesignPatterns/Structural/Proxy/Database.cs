using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Proxy
{
    public class Database : IDatabase, IDisposable
    {
        private int _connectionCounter = 0;

        public void Dispose()
        {
            Console.WriteLine("Connection closed");
        }

        public Database()
        {
            Console.WriteLine("Comnnection open");
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if(_connectionCounter >= 5)
            {
                Console.WriteLine($"Request {parameter} failed!");
                return null;
            }

            Interlocked.Increment(ref _connectionCounter);
            Console.WriteLine($"Opening connection {_connectionCounter}");
            await Task.Delay(new Random(_connectionCounter).Next(1000, 3000));

            Console.WriteLine($"Request {parameter} completed!");
            Interlocked.Decrement(ref _connectionCounter);
            return parameter;
        }
    }
}

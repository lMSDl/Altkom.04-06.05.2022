using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.II
{
    public interface ICartService
    {
        void Add(int cartId, int productId, float price);
        float GetValue(int cartId); 
    }
}

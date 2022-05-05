using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class DiscountHandler : BaseDiscountHandler
    {
        private float MaxDiscount { get; }
        private float MinPrice {get; }
        public string Name { get; set; }

        public DiscountHandler(float maxDiscount, float minPrice, IDiscountHandler next) : base(next)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }

        public override bool Discount(float value, float price)
        {
            if (price >= MinPrice && MaxDiscount >= value)
            {
                Console.WriteLine($"Rabatu udzielił {Name}");
                return true;
            }
            Console.WriteLine($"Rabatu nie może udzielić {Name}");
            return base.Discount(value, price);
        }
    }
}

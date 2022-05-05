using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.II
{
    public class ShoppingFacade
    {
        IProductService productService;
        ICartService cartService;
        IPaymentService paymentService;

        public ShoppingFacade(IProductService productService, ICartService cartService, IPaymentService paymentService)
        {
            this.productService = productService;
            this.cartService = cartService;
            this.paymentService = paymentService;
        }

        public void Buy(int[] itemsId)
        {
            var cartId = 11212;

            foreach (var item in itemsId)
            {
                var price = productService.GetPrice(item);
                cartService.Add(cartId, item, price);
            }

            paymentService.Pay(cartId, cartService.GetValue(cartId));
        }
    }
}

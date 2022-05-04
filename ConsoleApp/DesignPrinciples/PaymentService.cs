using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int id, float amount)
        {
            var paymentAccount = FindById(id);
            return paymentAccount?.Charge(amount) ?? false;
        }

        public void Fund(int id, float amount)
        {
            var paymentAccount = FindById(id);
            paymentAccount?.Fund(amount);
        }

        private PaymentAccount FindById(int id)
        {
            return PaymentAccounts.SingleOrDefault(x => x.Id == id);
        }
    }
}

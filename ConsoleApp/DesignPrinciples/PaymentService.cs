using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeletePaymentAccount(PaymentAccount paymentAccount)
        {
            return PaymentAccounts.Remove(paymentAccount);
        }

        public PaymentAccount FindByAllowedDebig(float allowedDebit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int id, float amount)
        {
            var paumentAccount = PaymentAccounts.SingleOrDefault(x => x.Id == id);
            if (paumentAccount == null)
            {
                return false;
            }

            if (paumentAccount.Income - paumentAccount.Outcome + paumentAccount.AllowedDebit < amount)
            {
                return false;
            }

            paumentAccount.Outcome += amount;
            return true;
        }

        public void Fund(int id, float amount)
        {
            var paumentAccount = PaymentAccounts.Where(x => x.Id == id).SingleOrDefault();
            if (paumentAccount == null)
            {
                return;
            }

            paumentAccount.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var paymentAccount = PaymentAccounts.Where(x => x.Id == id).SingleOrDefault();
            return paymentAccount?.Income - paymentAccount?.Outcome;
        }
    }
}

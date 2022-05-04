namespace DesignPrinciples
{
    public class PaymentAccount
    {
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }

        public float Balance => Income - Outcome + AllowedDebit;

        public bool HasDebit()
        {
            return Income - Outcome < 0;
        }

        public bool Charge(float amount)
        {
            if (Balance < amount)
            {
                return false;
            }

            Outcome += amount;
            return true;
        }

        public void Fund(float amount)
        {
            Income += amount;
        }
    }
}
}

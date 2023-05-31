using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram.PaymentMeans
{
    internal class CashBackCard: PaymentCard
    {

        public float CashBackPercent { get; set; } = 0.02f;


        public CashBackCard(string cardNumber, CardExpDate cardExpDate, int cardCVV, float balance, float cashBackPercent) : base(cardNumber, cardExpDate, cardCVV, balance)
        {
            CashBackPercent = cashBackPercent;

        }

        public override bool MakePayment(float amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                Balance += amount * CashBackPercent;
                Console.WriteLine("The payment of " + amount + "coins has been made by CashBack Card.");
                return true;
            }
            return false;
        }

        public override bool TopUp(float amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "CashBack Card balance: " + Balance;
        }

    }
}

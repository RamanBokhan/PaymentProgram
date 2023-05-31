using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram.PaymentMeans
{
    internal class DebetCard : PaymentCard
    {
        public float DebetPercent { get; set; }

        public DebetCard(string cardNumber, CardExpDate cardExpDate, int cardCVV, float balance, float debetPercent) : base(cardNumber, cardExpDate, cardCVV, balance)
        {
            DebetPercent = debetPercent;
            
        }

        public override bool MakePayment(float amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                Console.WriteLine("The payment of " + amount + "coins has been made by Debet Card.");
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
            return "Debet Card balance: " + Balance;
        }
    }
}

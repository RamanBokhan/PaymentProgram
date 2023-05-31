using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram.PaymentMeans
{
    internal class CreditCard : PaymentCard
    {
        public float CreditPercent { get; set; }
        public float CreditLimit { get; set; }

      

        public CreditCard(string cardNumber, CardExpDate cardExpDate, int cardCVV, float balance, float creditPercent, float creditLimit) : base(cardNumber, cardExpDate, cardCVV, balance)
        {
            CreditPercent = creditPercent;
            CreditLimit = creditLimit;

        }

        public override bool MakePayment(float amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                Console.WriteLine("The payment of " + amount + "coins has been made by Credit Card.");
                return true;
            }
            else if (CreditLimit + Balance > amount)
            {
                CreditLimit = CreditLimit + Balance - amount;
                Balance = 0;
                Console.WriteLine("The payment of " + amount + "coins has been made by credit card using credit funds.");
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
            return "Credit Card balance: " + Balance + ",  Credit Card limit:  " + CreditLimit;
        }
    }
}
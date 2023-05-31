using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram.PaymentMeans
{
    internal class BitCoin: IPayment
    {
        public float Balance { get; set; }

        public BitCoin(float balance)
        {
            Balance = balance;
        }

        public bool MakePayment(float amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
                Console.WriteLine("The payment of " + amount + "coins has been made in BitCoin.");
                return true;

            }
            return false;
        }

        public bool TopUp(float amount)
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
            return "BitCoin balance: " + Balance;
        }
    }
}

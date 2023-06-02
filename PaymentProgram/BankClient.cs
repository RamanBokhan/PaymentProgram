using PaymentProgram.PaymentMeans;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram
{
    internal class BankClient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        private List<IPayment> PaymentMeans { get; set; }

        public BankClient(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PaymentMeans = new List<IPayment>();
        }

        public bool AddPaymentMean(IPayment mean) 
        {
            PaymentMeans.Add(mean);
            return true;
        }

        private bool PayLogic (List<IPayment> list, float amount) 
        {
            foreach (IPayment item in list)
            {
                if (item.MakePayment(amount) == true)
                {
                    return true;
                }
            }
            return false;

        }
        public bool Pay (float amount) 
        {
            if (PayLogic(PaymentMeans.Where(x => x is Cash).ToList(), amount))
            {
                return true;
            }
            else if (PayLogic(PaymentMeans.Where(x => x is DebetCard).ToList(), amount))
            {
                return true;
            }
            else if (PayLogic(PaymentMeans.Where(x => x is CreditCard).ToList(), amount))
            {
                return true;
            }
            else if (PayLogic(PaymentMeans.Where(x => x is CashBackCard).ToList(), amount))
            {
                return true;
            }
            else if (PayLogic(PaymentMeans.Where(x => x is BitCoin).ToList(), amount))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "BankClient:" + FirstName + ", " + LastName + ", " + Address ;

        }

        public string GetPaymentMean()
        {
            return string.Join( "\n" , PaymentMeans);

        }

        public int CountCard() 
        {
            return PaymentMeans.Count;
        }

        public float AmountOfMoney() 
        {
            float amountOfMoney = 0;
            foreach (var card in PaymentMeans) 
            {
                amountOfMoney = +card.Balance;            
            }
            return amountOfMoney;
        }

        public float GetMaxOfMoney() 
        {
            float maxOfMoney = 0;
            foreach (var card in PaymentMeans)
            { 
                if (card.Balance > maxOfMoney) 
                {
                    maxOfMoney = card.Balance;
                }
            }
            return maxOfMoney;
        }
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram.PaymentMeans
{
    internal abstract class PaymentCard : IPayment
    {
        public string CardNumber { get; set; }
        public CardExpDate CardExpDate { get; set; }
        public int CardCVV { get; set; }

        public float Balance { get; set; }

        public PaymentCard(string cardNumber, CardExpDate cardExpDate, int cardCVV, float balance)
        {

            CardNumber = cardNumber;
            CardExpDate = cardExpDate;
            CardCVV = cardCVV;
            Balance = balance;
        }
        public abstract bool MakePayment(float amount);


        public abstract bool TopUp(float amount);

    }
}
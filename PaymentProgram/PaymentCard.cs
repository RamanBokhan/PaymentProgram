using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram
{
    internal class PaymentCard
    {
        public string CardNumber;
        public string CardExpDate;
        public string CardholderName;
        public int CardCVV;

        public PaymentCard(string cardNumber, string cardExpDate, string cardholderName, int cardCVV)
        { 
        
            CardNumber = cardNumber;
            CardExpDate = cardExpDate;
            CardholderName = cardholderName;
            CardCVV = cardCVV;
                    
        }



    }
}
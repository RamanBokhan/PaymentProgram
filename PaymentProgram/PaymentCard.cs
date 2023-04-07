using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram
{
    internal class PaymentCard
    {
        private string CardNumber;
        private string CardExpDate;
        private string CardholderName;
        private int CardCVV;

        public PaymentCard(string cardNumber, string cardExpDate, string cardholderName, int cardCVV)
        { 
        
            CardNumber = cardNumber;
            CardExpDate = cardExpDate;
            CardholderName = cardholderName;
            CardCVV = cardCVV;
                    
        }

        public string GetFullInformation()
        {

            return string.Format("CardNumber: {0}, CardExpDate: {1}, CardholderName: {2}, Card CVV: {3}", CardNumber, CardExpDate, CardholderName, CardCVV);


        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram
{
    internal class CardExpDate
    {
        public int CardExpYear { get; set; }
        public int CardExpMonth { get; set;}

        public CardExpDate (int cardExpMonth, int cardExpYear)
        {
            CardExpYear = cardExpYear;
            CardExpMonth = cardExpMonth;
        }
        public override string ToString()
        {
            return CardExpMonth + "/" + CardExpYear;
        }
    }
}

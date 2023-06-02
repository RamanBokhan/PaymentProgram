using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram
{
    internal interface IPayment

    {
        public float Balance { get; set; }
        bool MakePayment (float amount);
        bool TopUp (float amount);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram
{
    internal interface IPayment
    {
        bool MakePayment (float amount);
        bool TopUp (float amount);
    }
}

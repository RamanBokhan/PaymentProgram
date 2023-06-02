using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram.Comparers
{
    internal class ClientNameComparer : IComparer<BankClient>
    {
        public int Compare(BankClient? x, BankClient? y)
        {
            if (x != null && y != null)
            {
                return x.LastName.CompareTo(y.LastName);
            }
            else if (x == null && y == null) return 0;
            else if (x == null && y != null) return 1;
            else return -1;
        }
    }
}

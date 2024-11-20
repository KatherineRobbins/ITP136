using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw13
{
    public class Commission : Employee
    {
        public Commission(int num, string fn, double commis) : base(num, fn)
        {
            Sales = commis;
        }

        public double Sales
        {
            get { return payAmt; }
            set { payAmt = value * .02; }
        }

        double payAmt;
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDemo.Lib
{
    public class VendorXyz: IVendor
    {
        public bool VerifyCreditCard(string cardNumber)
        {
            return true;
        }
    }
}

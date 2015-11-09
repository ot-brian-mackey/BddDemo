using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDemo.Lib
{
    public class Payment: IPayment
    {
        public IVendor vendor;

        public Payment(IVendor vendor)
        {
            this.vendor = vendor;
        }

        public bool Accept(string creditCardNumber)
        {
            //do work
            var status = vendor.VerifyCreditCard(creditCardNumber);
            return status;
        }
    }
}

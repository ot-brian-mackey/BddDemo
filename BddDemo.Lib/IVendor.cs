using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDemo.Lib
{
    public interface IVendor
    {
        bool VerifyCreditCard(string cardNumber);
    }
}

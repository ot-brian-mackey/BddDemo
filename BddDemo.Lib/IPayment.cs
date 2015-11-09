using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BddDemo.Lib
{
    public interface IPayment
    {
        bool Accept(string creditCardNumber);
    }
}

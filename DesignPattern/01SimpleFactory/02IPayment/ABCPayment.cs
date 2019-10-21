using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01SimpleFactory._02IPayment
{
    class ABCPayment : IPayment
    {
        public String Payfor(decimal money)
        {
            return "农业银行支付";
        }
    }
}

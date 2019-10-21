using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01SimpleFactory._02IPayment
{
    class ICBCPayment : IPayment
    {
        public string Payfor(decimal money)
        {
            return "中国工商银行支付";
        }
    }
}

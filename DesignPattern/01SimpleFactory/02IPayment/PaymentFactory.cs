using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01SimpleFactory._02IPayment
{
    class PaymentFactory
    {
        public static IPayment CreatePayment(string bank)
        {
            IPayment payment = null;
            switch (bank)
            {
                case "ABC":
                    payment = new ABCPayment();
                    break;
                case "ICBC":
                    payment = new ICBCPayment();
                    break;
                default:
                    break;
            }
            return payment;
        }
    }
}

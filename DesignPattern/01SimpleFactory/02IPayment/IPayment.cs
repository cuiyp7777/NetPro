using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01SimpleFactory._02IPayment
{
    interface IPayment
    {
        string Payfor(decimal money);
    }
}

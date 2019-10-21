using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01SimpleFactory
{
    class ConcreteProduct_Minus : Product_Operation
    {
        public override double GetResult()
        {
            return _NumA - _NumB;
        }
    }
}

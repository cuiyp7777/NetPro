using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._04FactoryMethod
{
    class _01Factory_IKFC_WingsFactory: _01Factory_IKFC
    {
        public _02KFCFood CreateFood()
        {
            return new _02KFCFood_Wings();
        }
    }
}

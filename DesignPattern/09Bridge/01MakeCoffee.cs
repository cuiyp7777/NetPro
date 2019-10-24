using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._09Bridge
{
    //行为接口（制咖啡：加奶、不加）
    abstract class _01MakeCoffee
    {
        public abstract void Making();
    }
}

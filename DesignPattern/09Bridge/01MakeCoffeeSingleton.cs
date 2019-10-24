
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._09Bridge
{
    /// <summary>
    /// 单件模式类用来加载当前MakeCoffee
    /// </summary>
    sealed class _01MakeCoffeeSingleton
    {
        private static _01MakeCoffee _instance;

        public _01MakeCoffeeSingleton(_01MakeCoffee instance)
        {
            _instance = instance;
        }

        public static _01MakeCoffee Instance()
        {
            return _instance;
        }
    }
}

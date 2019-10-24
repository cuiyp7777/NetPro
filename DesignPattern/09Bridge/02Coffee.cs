using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._09Bridge
{
    //抽象：大杯、小杯
    abstract class _02Coffee
    {
        private _01MakeCoffee _makeCoffee;

        public _02Coffee()
        {
            _makeCoffee = _01MakeCoffeeSingleton.Instance();
        }
        public _01MakeCoffee MakeCoffee()
        {
            return this._makeCoffee;
        }

        public abstract void Make();
    }
}

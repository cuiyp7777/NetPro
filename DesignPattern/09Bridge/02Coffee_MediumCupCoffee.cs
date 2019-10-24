using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._09Bridge
{
    class _02Coffee_MediumCupCoffee : _02Coffee
    {
        public override void Make()
        {
            _01MakeCoffee makeCoffee = this.MakeCoffee();
            Console.Write("中杯");
            makeCoffee.Making();
        }
    }
}

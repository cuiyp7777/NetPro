using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._12Flyweight
{
    class _01FlyweightConcrete : _01Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("可共享，ConcreteFlyweight: " + extrinsicstate);
        }
    }
}

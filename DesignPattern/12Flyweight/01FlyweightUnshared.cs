using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._12Flyweight
{
    class _01FlyweightUnshared : _01Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("并非所有的类都共享，UnsharedConcreteFlyweight: " + extrinsicstate);
        }
    }
}

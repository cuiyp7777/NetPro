using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._11Facade
{
    class Facade
    {
        private _01SubSystem _one;
        private _02SubSystem _two;
        private _03SubSystem _three;
        private _04SubSystem _four;

        public Facade()
        {
            _one = new _01SubSystem();
            _two = new _02SubSystem();
            _three = new _03SubSystem();
            _four = new _04SubSystem();
        }

        //自定义外观方法A
        public void MethodA()
        {
            Console.WriteLine("\n MethodA() ---- ");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }
        //自定义外观方法B
        public void MethodB()
        {
            Console.WriteLine("\n MethodB() ---- ");
            _two.MethodTwo();
            _three.MethodThree();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    //泛型类
    public class Test<T>
    {
        private T _inputParms;
        public Test(T inputParms)
        {
            this._inputParms = inputParms;
        }

        public T GetParms()
        {
            return _inputParms;
        }
    }
    //自定义
    public class A
    {
        public string ID
        {
            get { return "This is ID Property."; }
        }
    }
    //使用方法
    //Test<int> intTest = new Test<int>(1);

    //Console.WriteLine(intTest.GetParms());

    //Test<A> ATest = new Test<A>(new A());

    //Console.WriteLine(ATest.GetParms().ID);

    //Console.Read();
}

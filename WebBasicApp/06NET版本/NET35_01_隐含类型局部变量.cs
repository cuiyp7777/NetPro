using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    class NET35_01_隐含类型局部变量
    {
        public void TestMethod()
        {
            //必须对var声明的变量赋值
            //Var声明的变量不能赋null;

            //Var只能声明局部变量；

            //不允许,改变var变量的类型
            var i = 5;//int

            var j = 23.56;//double

            var k = "C Sharp";//string

            //var x;//错误

            //var y = null;//错误

            //var z = { 1, 2, 3 };//错误
        }
    }
}

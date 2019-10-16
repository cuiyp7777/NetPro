using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    class NET35_02_匿名类型
    {
        public void AnonyMousMethod()
        {
            //匿名类型允许定义行内类型，无须显式定义类型。常和var配合使用来声明匿名类型。

            var p1 = new { Id = 1, Name = "tony", Age = 21 };//属性也不需要申明

            var p2 = new { Id = 2, Name = "dream", Age = 21 };

            var p3 = new { Id = 3, age = 21, Name = "tony" };

            var intArray = new[] { 2, 3, 5, 6 };

            var strArray = new[] { "Hello", "World" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    class NET35_04_Lambda表达式
    {
        //Lambda表达式格式：(参数列表)=>表达式或语句块
        //具体意义：定义Lambda接受参数列表，运行表达式或语句块返回表达式或语句块的值传给这个参数列表。

        public void LambdaMethod()
        {
            List<string> list = new List<string>();
            var inString = list.FindAll(s => s.IndexOf("tony") >= 0);

            //Lambda表达式的参数列表可以有一个或多个参数，或者无参数。
            //在有单一的隐型参数的lambda表达式中，圆括号可以从参数列表中省略。
            //(x, y) => x * y;//多参数，隐式类型=>表达式

            //x => x * 10;//单参数，隐式类型=>表达式

            //x => { return x * 10; }; //单参数，隐式类型=>语句块

            //(int x) => x * 10;//单参数，显式类型=>表达式

            //(int x) => { return x * 10; };//单参数，显式类型=>语句块

            //() => Console.WriteLine(); //无参数下面看这个例子：

            List<User> user = new List<User>{
                new User{Id=1,Name="tony",Age=21},
                new User{Id=2,Name="tony2",Age=22}
            };
            //获取特定人时所用的过滤条件，p参数属于User类型
            var result1 = user.Where(p => p.Name == "tony").ToList() ;
            //用User对象的Age值计算平均年龄
            var result2 = user.Average(p => p.Age);
        }
    }

    //public class User
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }

    //    public int Age { get; set; }
    //}
}

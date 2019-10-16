using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    public class AnonyClass
    {
        delegate void WriteString(string s);

        //测试执行方法
        public void ExecuteMethod()
        {
            int a = 1;
            //char vv = "11";
            //1、匿名方法
            WriteString p = delegate(string j)
            {
                System.Console.WriteLine(j);
            };
            //调用匿名方法输出的结果
            p(" 这个委托使用的是匿名方法");

            //方法2
            p = new WriteString(NameMethod);
            //调用已命名方法结果
            p("这里使用的是已经命名的方法");

        }
        //代理相关关联的有名称方法
        public void NameMethod(string s)
        {
            Console.WriteLine(s);
        }
    }
}

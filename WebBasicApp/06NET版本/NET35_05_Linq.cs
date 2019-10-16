using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    class NET35_05_Linq
    {
        public void LinqMethod()
        {
            //查询一个int 数组中小于5的数字，并按照大小顺序排列
            int[] arr = new int[] { 8, 5, 89, 3, 56, 4, 1, 58 };

            var m = from n in arr where n < 5 orderby n select n;

            //在我们罗列的语言字符串中，我们希望按照字符长短，分类罗列出来，实现代码如下：
            string[] languages = { "Java", "C#", "C++", "Delphi", "VB.net", "VC.net", 
                                     "C++ Builder", "Kylix", "Perl", "Python" };
             //into 关键字表示将前一个查询的结果视为后续查询的生成器，这里是跟 group by一起使用的
            var result = from item in languages
                         orderby item
                         group item by item.Length into lengthGroup
                         select lengthGroup;

        }
    }
}

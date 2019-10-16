using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    class NET2_04_迭代器
    {
        //类中实现多个迭代器，每个迭代器都必须像任何类成员一样有唯一的名称，
        //并且可以在foreach语句中被客户端代码调用；
        //迭代器的返回类型必须为IEnumerable或IEnumerator。
        public void IenumMethod()
        {
            DaysOfTheWeek week = new DaysOfTheWeek();

            foreach (string day in week)
            {
                System.Console.Write(day + " ");
            }
            Console.Read();
        }
    }
    public class DaysOfTheWeek : System.Collections.IEnumerable
    {

        string[] m_Days = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };

        public System.Collections.IEnumerator GetEnumerator()
        {
            //迭代器代码使用yield return语句依次返回每个元素。yield break将终止迭代；
            for (int i = 0; i < m_Days.Length; i++)
            {

                yield return m_Days[i];

            }

        }

    }
}

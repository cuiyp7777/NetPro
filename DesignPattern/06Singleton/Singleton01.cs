using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern._06Singleton
{
    //使用密封类，不可继承
    //非线程安全，用于单线程模式
    sealed class Singleton01
    {
        private static Singleton01 _instance;

        //私有构造函数，防止New实例对象
        private Singleton01()
        {

        }

        /// <summary>
        /// 定义公有静态方法，获取实例，并加入判断，保证实例只被创建一次
        /// </summary>
        /// <returns></returns>
        public static Singleton01 Instance()
        {
            //使用延迟初始化
            // 若类的实例不存在则创建实例，若存在则返回实例
            // 注: 非线程安全
            if (_instance==null)
            {
                Thread.Sleep(100);
                _instance = new Singleton01();
            }
            return _instance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBasicApp._03特性
{
    /// <summary>
    /// 定义一个继承自System.Attribute的类型MyCustomAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class MyCustomAttribute : Attribute
    {
        private string className;


        public MyCustomAttribute(string className)
        {
            this.className = className;
        }
        // 一个只读属性ClassName
        public string ClassName
        {
            get { return className; }
        }
    }
}
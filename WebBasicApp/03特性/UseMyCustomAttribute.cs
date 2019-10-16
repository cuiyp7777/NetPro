using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBasicApp._03特性
{

    /// <summary>
    /// 使用MyCustomAttribute【构造方法：MyCustomAttribute(string className)】
    /// </summary>
    [MyCustom("使用特性定义的类名称")]
    public class UseMyCustomAttribute
    {
    }
}
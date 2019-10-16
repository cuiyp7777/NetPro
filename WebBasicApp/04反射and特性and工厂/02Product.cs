using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebBasicApp._04反射and特性and工厂._00Attribute;

namespace WebBasicApp._04反射and特性and工厂
{

    /// <summary>
    /// 产口接口
    /// 使用ProductList特性，其构造函数：ProductListAttribute(Type[] products)
    /// </summary>
    [ProductList(new Type[] { typeof(Roof), typeof(Window), typeof(Pillar) })]
    public interface IProduct
    {
        string GetName();
    }

    //具体实现产品接口的产品类：窗户、屋顶和柱子

    /// <summary>
    ///使用Product特性，其构造函数ProductAttribute(RoomParts part)
    /// </summary>
    [Product(RoomParts.Roof)]
    public class Roof : IProduct
    {
        // 实现接口，返回产品名字
        public string GetName()
        {
            return "屋顶";
        }
    }
    [Product(RoomParts.Window)]
    public class Window : IProduct
    {
        // 实现接口，返回产品名字
        public string GetName()
        {
            return "窗户";
        }
    }
    [Product(RoomParts.Pillar)]
    public class Pillar : IProduct
    {
        // 实现接口，返回产品名字
        public string GetName()
        {
            return "柱子";
        }
    }
}
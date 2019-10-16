using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using static WebBasicApp._04反射and特性and工厂._00Attribute;

namespace WebBasicApp._04反射and特性and工厂
{
    //定义工厂接口，产品接口与产品类型的枚举
    /// <summary>
    /// 屋子零件
    /// </summary>
    public enum RoomParts
    {
        Roof,
        Window,
        Pillar
    }
    /// <summary>
    /// 工厂类
    /// </summary>
    public class Factory
    {
        public IProduct Produce(RoomParts part)
        {
            // 通过反射从IProduct接口中获得属性从而获得所有产品列表
            //参数1：Iproduct接口，type:ProductListAttribute
            ProductListAttribute attr =
               (ProductListAttribute)Attribute.GetCustomAttribute(typeof(IProduct), typeof(ProductListAttribute));

            // 遍历所有的实现产品零件类型
            foreach (var type in attr.ProductList)
            {
                // 利用反射查找其属性
                ProductAttribute pa =
                    (ProductAttribute)Attribute.GetCustomAttribute(type, typeof(ProductAttribute));
                // 确定是否是需要到的零件
                if (pa.RoomPart == part)
                {
                    // 利用反射动态创建产品零件类型实例
                    object product = Assembly.GetExecutingAssembly().CreateInstance(type.FullName);
                    return product as IProduct;
                }
            }
            return null;
        }
    }
}
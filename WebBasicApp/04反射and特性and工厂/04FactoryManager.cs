using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBasicApp._04反射and特性and工厂
{
    public class FactoryManager
    {
        public static IProduct GetProduct(RoomParts part)
        {
            // 一共只有一个工厂
            Factory factory = new Factory();
            IProduct product = factory.Produce(part);
            Console.WriteLine("生产了一个产品：{0}", product.GetName());
            return product;
        }
    }
}
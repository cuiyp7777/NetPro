using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._02AbstractFactory._01Kfcfood
{
    /// <summary>
    /// 实现创建具体产品对象的操作,不是负责一种具体Product的创建，而是负责一个Product族的创建。
    /// </summary>
    class Factory_CheapPackage : Factory_Abstract_IKFCFactory
    {
        public Factory_CheapPackage()
        {
            Console.WriteLine("===便宜套餐===");
        }
        public KFCFood CreateFood()
        {
            return new KFCFood_Product_Wings();
        }
        public KFCDrink CreateDrink()
        {
            return new KFCDrink_Product_Coke();
        }
    }
}

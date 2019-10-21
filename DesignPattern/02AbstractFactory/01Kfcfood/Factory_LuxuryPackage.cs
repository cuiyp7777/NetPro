using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._02AbstractFactory._01Kfcfood
{
    class Factory_LuxuryPackage : Factory_Abstract_IKFCFactory
    {
        public Factory_LuxuryPackage()
        {
            Console.WriteLine("===豪华套餐===");
        }
        public KFCFood CreateFood()
        {
            return new KFCFood_Product_Chicken();
        }
        public KFCDrink CreateDrink()
        {
            return new KFCDrink_Product_Coffee();
        }
    }
}

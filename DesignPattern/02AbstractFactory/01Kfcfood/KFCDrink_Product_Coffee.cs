using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._02AbstractFactory._01Kfcfood
{
    class KFCDrink_Product_Coffee : KFCDrink
    {
        public override void Display()
        {
            Console.WriteLine("咖啡+1");
        }
    }
}

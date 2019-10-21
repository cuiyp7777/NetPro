using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._02AbstractFactory._01Kfcfood
{
    class KFCFood_Product_Chicken : KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡腿+1");
        }
    }
}

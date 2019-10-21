using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._02AbstractFactory._01Kfcfood
{
    /// <summary>
    /// 声明一个创建抽象产品对象的操作接口
    /// </summary>
    interface Factory_Abstract_IKFCFactory
    {
        KFCFood CreateFood();
        KFCDrink CreateDrink();
    }
}

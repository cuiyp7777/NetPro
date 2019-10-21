using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._04FactoryMethod
{
    /// <summary>
    /// 抽象的工厂角色，声明工厂方法，返回【Product】类型的对象
    /// </summary>
    interface _01Factory_IKFC
    {
        _02KFCFood CreateFood();
    }
}

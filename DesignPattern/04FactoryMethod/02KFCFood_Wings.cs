using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._04FactoryMethod
{
    /// <summary>
    /// 具体Product角色
    /// </summary>
    class _02KFCFood_Wings : _02KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡翅 + 1");
        }
    }
}

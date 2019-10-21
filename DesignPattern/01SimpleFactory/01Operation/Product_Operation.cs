using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01SimpleFactory
{
    //抽象类：父类是抽象类+抽象方法，子类必须override父亲方法，否则子类必须是抽象类
    abstract class Product_Operation
    {
        public double _NumA { get; set; }
        public double _NumB { get; set; }

        public virtual double GetResult()
        {
            const double result = 0;
            return result;
        }
    }
}

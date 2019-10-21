using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._01SimpleFactory
{
    //运算方法
    public enum OPE
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }
    //静态类
    static class Factory_OperationFactory
    {

        public static Product_Operation CreateOperate(OPE oPE)
        {
            Product_Operation per = null;
            switch (oPE)
            {
                case OPE.PLUS:
                    per = new ConcreteProduct_Plus();
                    break;
                case OPE.MINUS:
                    per = new ConcreteProduct_Minus();
                    break;
                case OPE.MULTIPLY:
                    per = new ConcreteProduct_Multiply();
                    break;
                case OPE.DIVIDE:
                    per = new ConcreteProduct_Divide();
                    break;
            }
            return per;
        }
    }
}

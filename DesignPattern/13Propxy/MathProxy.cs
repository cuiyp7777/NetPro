using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._13Propxy
{
    //维持一个引用，使得代理可以访问Subject。
    //提供一个与Subject的接口相同的接口，这样代理就可以替代Subject。
    //控制对Subject的访问，并可能负责对Subject的创建和删除
    class MathProxy : IMath
    {
        private Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }

        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }

        public double Div(double x, double y)
        {
            return _math.Div(x, y);
        }
    }
}

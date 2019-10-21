using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._07Adapter
{
    //对象适配器结构实现
    class Adapter : _01ITarget
    {
        public _02Power _power;
        public Adapter(_02Power power)
        {
            this._power = power;
        }
        public void GetPower()
        {
            _power.GetPower220V();
            Console.WriteLine("得到手机的充电电压！");
        }
    }
}

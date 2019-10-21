using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._8Observer
{
    //抽象的观察者,定义一个发送变化通知更新的接口
    abstract class _01Observer
    {
        public abstract void Update();
    }
}

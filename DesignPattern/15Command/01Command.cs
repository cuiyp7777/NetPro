using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._15Command
{
    //命令抽象类，声明一个执行操作的接口Execute，该抽象类并不实现这个接口
    abstract class _01Command
    {
        protected _00Receiver receiver;

        public _01Command(_00Receiver receiver)
        {
            this.receiver = receiver;
        }
        public abstract void Execute();
    }
}

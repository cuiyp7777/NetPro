using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._15Command
{
    class _00Receiver
    {
        //命令的接收者，知道如何实施与执行一个请求相关的操作
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}

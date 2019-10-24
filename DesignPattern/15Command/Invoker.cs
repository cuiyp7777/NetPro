using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._15Command
{
    //命令的接收者，将命令请求传递给相应的命令对象，
    //每个ConcreteCommand都是一个Invoker的成员
    class Invoker
    {
        public _01Command _command;

        public Invoker(_01Command command)
        {
            _command = command;
        }

        public void ExcuteCommand()
        {
            _command.Execute();
        }
    }
}

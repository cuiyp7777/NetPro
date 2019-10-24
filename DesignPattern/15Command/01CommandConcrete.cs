using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._15Command
{
    class _01CommandConcrete : _01Command
    {
        public _01CommandConcrete(_00Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            this.receiver.Action();
        }
    }
}

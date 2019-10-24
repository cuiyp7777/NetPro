using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._14ChainofResponsibility
{
    abstract class _01Handler
    {
        protected _01Handler successor;

        public void SetSuccessor(_01Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}

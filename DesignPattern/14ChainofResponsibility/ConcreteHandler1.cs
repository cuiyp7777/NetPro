using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._14ChainofResponsibility
{
    class ConcreteHandler1 : _01Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                //successor 继承 自Handler
                successor.HandleRequest(request);
            }
        }
    }
}

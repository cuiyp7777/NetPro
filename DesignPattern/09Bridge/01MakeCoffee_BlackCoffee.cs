using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._09Bridge
{
    //行为：不加奶
    class _01MakeCoffee_BlackCoffee : _01MakeCoffee
    {
        public override void Making()
        {
            Console.WriteLine("黑咖啡");
        }
    }
}

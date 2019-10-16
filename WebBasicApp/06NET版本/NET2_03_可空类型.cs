using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    class NET2_03_可空类型
    {
        public void NullMethod()
        {
            int? i = 10;

            bool? flag = null;

            int? x = 10;

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("Undefined");
            }
            if (flag.HasValue)
            {

                System.Console.WriteLine(flag.Value);
            }
            else
            {
                System.Console.WriteLine("Undefined");
            }
        }
    }
}

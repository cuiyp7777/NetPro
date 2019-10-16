using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBasicApp._04反射and特性and工厂
{
    class NET35_03_初始化器
    {
        public void InitialMethod()
        {
            //对象初始化器由一系列成员对象组成，其对象必须初始化，用逗号间隔，使用{}封闭。
            User user = new User { Id = 1, Name = "tony", Age = 21 };
            List<User> userList = new List<User>{
                new User{Id=1,Name="tony",Age=21},
                new User{Id=2,Name="dream",Age=12}
                };

            //集合初始化器由一系列集合对象组成，用逗号间隔，使用{}封闭。
            List<int> num = new List<int> { 0, 1, 2, 6, 7, 8, 9 };
        }
    }

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}

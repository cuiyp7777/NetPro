using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebMvc5.Models;

namespace WebMvc5.DAL
{
    //第一次运行程序时新建数据库，插入测试数据
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        //创建一个colletion ,添加到适当的 DbSet property, 保存到数据库
        protected override void Seed(AccountContext context)
        {
            ////通过context将entities添加到database中去
            //var sysUsers = new List<SysUser>
            //{
            //    new SysUser{ UserName="Tom", PassWord="1",Email="Tom@sohu.com" },
            //     new SysUser{ UserName="Jerry", PassWord="2",Email="Jerry@sohu.com" }
            //};
            //sysUsers.ForEach(s => context.SysUsers.Add(s));
            ////保存到数据库
            //context.SaveChanges();
            //var sysRoles = new List<SysRole>
            //{
            //    new SysRole{RoleName="admin",RoleDesc="administrator" },
            //    new SysRole{RoleName="General",RoleDesc="General user" }
            //};
            //sysRoles.ForEach(s => context.SysRoles.Add(s));
            //context.SaveChanges();
        }
    }
}
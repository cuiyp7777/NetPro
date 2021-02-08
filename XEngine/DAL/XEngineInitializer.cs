using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Models;

namespace XEngine.DAL
{
    public class XEngineInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<XEngineContext>
    {
        protected override void Seed(XEngineContext context)
        {
            //var sysUsers = new List<SysUser>
            //{
            //    new SysUser{ID=1,Name="ZS",CName="张三",Email="zs@xengine.com",PassWord="1",ModifiedDate=DateTime.Now },
            //    new SysUser{ ID=2,Name="LS",CName="李四",Email="zs@xengine.com",PassWord="1",ModifiedDate=DateTime.Now},
            //    new SysUser{ ID=3,Name="WW",CName="王五",Email="zs@xengine.com",PassWord="1",ModifiedDate=DateTime.Now}
            //};
            //sysUsers.ForEach(s => context.SysUsers.Add(s));
            //context.SaveChanges();

            //var sysRoles = new List<SysRole>
            //{
            //    new SysRole{ID=1,Name="Administrator",CName="管理员",Description="Administrator,System",ModifiedDate=DateTime.Now },
            //    new SysRole{ID=2,Name="General User",CName="一般用户",Description="Greneral User",ModifiedDate=DateTime.Now },
            //};
            //sysRoles.ForEach(s => context.SysRoles.Add(s));
            //context.SaveChanges();

            //var sysUserRoles = new List<SysUserRole>
            //{
            //    new SysUserRole{SysUserID=1,SysRoleID=1,ModifiedDate=DateTime.Now },
            //    new SysUserRole{SysUserID=1,SysRoleID=2,ModifiedDate=DateTime.Now },
            //    new SysUserRole{SysUserID=2,SysRoleID=1,ModifiedDate=DateTime.Now },
            //    new SysUserRole{SysUserID=3,SysRoleID=2,ModifiedDate=DateTime.Now },
            //};
            //sysUserRoles.ForEach(s=>context.SysUserRoles.Add(s));
            //context.SaveChanges();
        }
    }
}
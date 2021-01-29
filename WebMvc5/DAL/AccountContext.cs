using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebMvc5.Models;

namespace WebMvc5.DAL
{
    //System.Data.Entity.DbContext,完成EF功能
    public class AccountContext : DbContext
    {
        //1、指定一个连接字符串,构造函数中的 base("AccountContext")
        public AccountContext() : base("AccountContext")
        {
        }
        //2、为每个entity set创建一个DbSet,一个entity set对应数据库中的一张表，一个entity对应表中的一行
        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //3、指定单数形式的表名
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
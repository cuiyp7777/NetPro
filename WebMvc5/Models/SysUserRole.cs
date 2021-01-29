using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc5.Models
{
    public class SysUserRole
    {
        //EF默认会将ID或classnameID生成主键
        public int ID { get; set; }
        // <navigation property name><primary key property name>这种形式的会成为外键
        //表名+ID 会成为外键
        public int SysUserID { get; set; }
        public int SysRoleID { get; set; }
        //定义为virtual的几个属性是 navigation 属性(virtual非必须) 一对多
        public virtual SysUser SysUser { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}
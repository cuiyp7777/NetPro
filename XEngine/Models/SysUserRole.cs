﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace XEngine.Models
{
    public class SysUserRole
    {

        [Key, Column(Order = 0)]
        [ForeignKey("SysUser")]
        public int SysUserID { get; set; }

        [Key,Column(Order =1)]
        [ForeignKey("SysRole")]
        public int SysRoleID { get; set; }

        public DateTime ModifiedDate { get; set; }

        //定义为virtual的几个属性是 navigation 属性(virtual非必须) 一对多
        public virtual SysUser SysUser { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}
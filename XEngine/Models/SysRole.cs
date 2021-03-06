﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XEngine.Models
{
    public class SysRole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CName { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        //定义为virtual的几个属性是 navigation 属性(virtual非必须) 一对多
        public ICollection<SysUserRole> sysUserRoles { get; set; }
    }
}
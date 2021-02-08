using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvc5.Models;

namespace WebMvc5.ViewModels
{
    public class UserRoleIndexData
    {
        public IEnumerable<SysUser> SysUsers { get; set; }

        public IEnumerable<SysUserRole> SysUserRoles { get; set; }

        public IEnumerable<SysRole> SysRoles { get; set; }
    }
}
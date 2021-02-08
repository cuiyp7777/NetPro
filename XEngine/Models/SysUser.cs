using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XEngine.Models
{
    public class SysUser
    {
        //EF默认会将ID或classnameID生成主键
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [DisplayName("密码")]
        public string PassWord { get; set; }
        [DisplayName("邮箱")]
        public string Email { get; set; }

        public string CName { get; set; }
        public string Description { get; set; }

        public DateTime ModifiedDate { get; set; }

        public ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}
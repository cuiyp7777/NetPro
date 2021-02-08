using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMvc5.Models
{
    public class SysUser
    {
        //EF默认会将ID或classnameID生成主键
        public int ID { get; set; }
        [DisplayName("用户名"), StringLength(10, ErrorMessage = "名字不能超过10个字。")]
        public string UserName { get; set; }
        [DisplayName("密码")]
        public string PassWord { get; set; }
        [DisplayName("邮箱")]
        public string Email { get; set; }
        [DisplayName("时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }

        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }

        public int? SysDepartmentID { get; set; }
        public virtual SysDepartment SysDepartment { get; set; }
    }
}
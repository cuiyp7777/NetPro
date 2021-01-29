using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMvc5.Models;

namespace WebMvc5.Repositories
{
    public interface ISysUserRepository
    {
        //查询所有用户
        IQueryable<SysUser> SelectAll();
        //条件查询
        SysUser SelectByName(string userName);
        //增加
        void Add(SysUser sysUser);
        //删除
        bool Delete(int id);
    }
}

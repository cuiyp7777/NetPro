using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvc5.DAL;
using WebMvc5.Models;

namespace WebMvc5.Repositories
{
    public class SysUserRepository : ISysUserRepository
    {
        protected AccountContext db = new AccountContext();

        public IQueryable<SysUser> SelectAll()
        {
            return db.SysUsers;
        }
        public SysUser SelectByName(string userName)
        {
            return db.SysUsers.FirstOrDefault(u => u.UserName == userName);
        }
        public void Add(SysUser sysUser)
        {
            db.SysUsers.Add(sysUser);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var delSysUser = db.SysUsers.FirstOrDefault(u => u.ID == id);
            if (delSysUser != null)
            {
                db.SysUsers.Remove(delSysUser);
                db.SaveChanges();
                return true;
            }
            return false;
        }




    }
}
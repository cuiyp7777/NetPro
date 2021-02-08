using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using XEngine.DAL;
using XEngine.Models;

namespace XEngine.Repositories
{
    public class SysUserRepository : ISysUserRepository
    {
        private XEngineContext _context;

        public SysUserRepository(XEngineContext context)
        {
            this._context = context;
        }
        public IEnumerable<SysUser> GetUsers()
        {
            return _context.SysUsers.ToList();
        }
        public SysUser GetUserById(int userID)
        {
            return _context.SysUsers.Find(userID);
        }
        public void InsertUser(SysUser user)
        {
            _context.SysUsers.Add(user);
        }
        public void DeleteUser(int userID)
        {
            SysUser user = _context.SysUsers.Find(userID);
            _context.SysUsers.Remove(user);
        }
        public void UpdateUser(SysUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            //对象会被Dispose释放，所以需要调用GC.SuppressFinalize来让对象脱离终止队列，防止对象终止被执行两次
            GC.SuppressFinalize(this);
        }
    }
}
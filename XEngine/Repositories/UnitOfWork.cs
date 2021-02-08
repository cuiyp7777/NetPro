using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.DAL;
using XEngine.Models;
using XEngine.Repositories;

namespace XEngine.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private XEngineContext _context = new XEngineContext();
        private IGenericRepository<SysUser> _userRepository;
        private IGenericRepository<SysRole> _roleRepository;
        private IGenericRepository<SysUserRole> _userRoleRepository;


        public IGenericRepository<SysUser> SysUserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new GenericRepository<SysUser>(_context);
                }
                return _userRepository;
            }
        }

        private IGenericRepository<SysRole> RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new GenericRepository<SysRole>(_context);
                }
                return _roleRepository;
            }
        }
        private IGenericRepository<SysUserRole> UserRoleRepository
        {
            get
            {
                if (_userRoleRepository == null)
                {
                    _userRoleRepository = new GenericRepository<SysUserRole>(_context);
                }
                return _userRoleRepository;
            }
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
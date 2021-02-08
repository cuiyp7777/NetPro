using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XEngine.Models;

namespace XEngine.Repositories
{
    public interface ISysUserRepository
    {
        IEnumerable<SysUser> GetUsers();
        SysUser GetUserById(int userID);

        void InsertUser(SysUser user);
        void DeleteUser(int userID);
        void UpdateUser(SysUser user);
        void Save();
    }
}

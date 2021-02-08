using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc5.DAL;
using WebMvc5.Models;
using WebMvc5.ViewModels;

namespace WebMvc5.Controllers
{
    public class UserRoleController : Controller
    {
        private AccountContext db = new AccountContext();
        // GET: UserRole
        public ActionResult Index(int? id)
        {
            var viewModel = new UserRoleIndexData();
            //var SysUsers = db.SysUsers.Include();
            viewModel.SysUsers = db.SysUsers.Include(u => u.SysDepartment).Include(u => u.SysUserRoles.Select(ur => ur.SysRole)).OrderBy(u => u.UserName);

            if (id != null)
            {
                ViewBag.UserID = id.Value;
                ViewBag.SysUserRoles = (viewModel.SysUserRoles.Where(u => u.SysUserID == id.Value)).Select(ur => ur.SysRole);
            }
            return View(viewModel);
        }

        public ActionResult Edit(int? id)
        {
            SysUser user = db.SysUsers.Include(u => u.SysDepartment).Include(u => u.SysUserRoles).Where(u => u.ID == id).Single();
            //取出用户下所有角色
            PopulateAssignedRoleData(user);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        private void PopulateAssignedRoleData(SysUser user)
        {
            var allRoles = db.SysRoles.ToList();
            //获取已经关联的用户的-角色
            var userRoles = new HashSet<int>(user.SysUserRoles.Select(r => r.SysRoleID));
            var viewModel = new List<AssignedRoleData>();
            foreach (var role in allRoles)
            {
                viewModel.Add(new AssignedRoleData
                {
                    RoleId = role.ID,
                    RoleName = role.RoleName,
                    Assigned = userRoles.Contains(role.ID)
                });
            }
            ViewBag.Roles = viewModel;
        }
    }
}
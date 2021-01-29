using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc5.DAL;
using WebMvc5.Models;

namespace WebMvc5.Controllers
{
    public class AccountController : Controller
    {
        //nstantiate 一个database context 对象
        private AccountContext db = new AccountContext();
        // GET: Account
        public ActionResult Index(string sortOrder, string searchString)
        {
            //普通、加条件、排序分页(必须Orderby排序)
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //表达式方式
            var users = from u in db.SysUsers select u;
            //var users1 = from u in db.SysUsers where u.UserName == "Tom" select u;
            //var users2 = (from u in db.SysUsers orderby u.UserName select u).Skip(0).Take(5);
            //连接查询
            //var users3 = from ur in db.SysUserRoles join u in db.SysUsers on ur.SysUserID equals u.ID select ur;
            //函数方式
            //var users = db.SysUsers;
            //var users1 = db.SysUsers.Where(u=>u.UserName=="Tom");
            //var users2 = db.SysUsers.OrderBy(u => u.UserName).Skip(0).Take(5);
            if (!string.IsNullOrEmpty(searchString))
            {
                users = users.Where(u => u.UserName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    users = users.OrderByDescending(u => u.UserName);
                    break;
                default:
                    users = users.OrderBy(u => u.UserName);
                    break;
            }
            //聚合查询
            var num = db.SysUsers.Count();//查总数
            var minId = db.SysUsers.Min(u => u.ID);//查最小ID
            //tolist 才会正式生效
            return View(users.ToList());
        }

        //跳转页面
        public ActionResult Login()
        {
            ViewBag.LoginState = "登陆前";
            return View();
        }
        //详情
        public ActionResult Details(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }
        //新建用户
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SysUser sysUser)
        {
            db.SysUsers.Add(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //修改用户
        public ActionResult Edit(int id)
        {
            var sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }
        [HttpPost]
        public ActionResult Edit(SysUser sysUser)
        {
            db.Entry(sysUser).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //删除用户
        public ActionResult Delete(int id)
        {
            var sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var sysUser = db.SysUsers.Find(id);
            db.SysUsers.Remove(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            var email = fc["InputEmail1"];
            var password = fc["InputPassword1"];
            var user = db.SysUsers.Where(b => b.Email == email & b.PassWord == password);
            if (user.Count() > 0)
            {
                ViewBag.LoginState = email + "登陆后";
            }
            else
            {
                ViewBag.LoginState = email + "用户不存在...";
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}
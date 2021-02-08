using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XEngine.DAL;
using XEngine.Models;
using XEngine.Repositories;

namespace XEngine.Controllers
{
    public class UserController : Controller
    {
        //private ISysUserRepository sysUserRepository = new SysUserRepository(new XEngineContext());
        //使用泛型
        //private IGenericRepository<SysUser> userRepository = new GenericRepository<SysUser>(new XEngineContext());
        //使用统一Repository
        private UnitOfWork unitOfWork = new UnitOfWork();




        // GET: User
        public ActionResult Index()
        {
            //var users = sysUserRepository.GetUsers();
            //var users = userRepository.Get();
            //var users = unitOfWork.SysUserRepository.Get();

            //加过滤条件
            //var users = unitOfWork.SysUserRepository.Get(fileter: u => u.Name == "ZS");
            //加排序
            var users = unitOfWork.SysUserRepository.Get(orderBy: q => q.OrderBy(u => u.Name));
            return View(users);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppApi.Controllers
{
    public class AppReController : Controller
    {
        // GET: AppRe
        public ActionResult Index()
        {
            return View();
        }
        //http://localhost:60233/AppRe/GetMvcData?id=1&name=aa
        [HttpGet]
        public string GetMvcData(int id, string name)
        {
            return "mvcData:" + id + "=" + name;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc5.Dal;

namespace WebMvc5.Controllers
{
    public class Administrator_Module_MappingController : Controller
    {
        EFDbContext db = new EFDbContext();

        // GET: Administrator_Module_Mapping
        public ActionResult Index()
        {
            var m = db.Administrator_Module_Mapping.ToList();
            return View(m);
        }
    }
}
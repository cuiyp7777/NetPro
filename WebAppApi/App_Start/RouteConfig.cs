using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppApi
{
    //MVC路由
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //RouteConfig，默认路由机制是通过url路径去匹配对应的action方法，
            //url: "{controller}/{action}/{id}"这个定义了我们url的规则，
            //{ controller}/{action}定义了路由的必须参数，{id}是可选参数
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAppApi
{
    //WEBAPI路由
    //默认路由是通过http的方法（get/post/put/delete）去匹配对应的action，也就是说webapi的默认路由并不需要指定action的名称
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //为了方便使用，可自己添加action路由
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

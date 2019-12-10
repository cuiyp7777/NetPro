using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAppApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //WebApi服务启动之后，会执行全局配置文件Global中的Application_Start方法中的GlobalConfiguration.Configure(WebApiConfig.Register);
        //然后执行WebApiConfig.cs中的注册方法
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

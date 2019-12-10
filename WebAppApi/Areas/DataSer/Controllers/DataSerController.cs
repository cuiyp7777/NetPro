using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppApi.Areas.DataSer.Controllers
{
    //首先在Area里创建一个域，然后在Controllers里添加webapi2控制器
    //在contrller里添加一个get方法，在Url里请求服务
    public class DataSerController : ApiController
    {
        //http://localhost:60233/api/dataser/GetAllData?id=1&name=ss
        [HttpGet]
        public string GetAllData(int id, string name)
        {
            return "webApiData:" + id + "=" + name;
        }
    }
}

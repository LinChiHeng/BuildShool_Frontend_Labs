using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ContactController : ApiController
    {
        [HttpGet]
        public object GetAll()
        {
            var dat = new string[,] { 
                { "Henry", "1990/01/01", "0912345678", "666@hotmail.com", "億光大樓", "朋友,同事" },
                { "Eric", "1970/01/01", "0923456789", "qqq@hotmail.com", "北科大樓", "客戶" } 
            };            

            return dat;
        }
    }
}

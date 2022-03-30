using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rohitkhatri.Controllers
{
    public class RohitController : ApiController
    {
        

        [HttpGet]
        [Route("Emp/Vikas")]
        public List<string> Emp()
        {
            List<string> ob = new List<string>()
            {
                "rohit",
                "vikas"
            };

            return ob;
        }


        [HttpGet]
        [Route("Emp/Rohit")]
        public List<string> Stu()
        {
            List<string> ob = new List<string>()
            {
                "rohit",
                "vikas"
            };

            return ob;
        }


    }
}
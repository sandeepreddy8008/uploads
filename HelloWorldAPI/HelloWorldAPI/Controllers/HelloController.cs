using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        

        // GET 
        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }

    }
}

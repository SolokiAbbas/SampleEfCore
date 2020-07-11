using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SampleEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        public ActionResult<string> Index()
        {
            HttpContext.Session.SetString("key", "value"); // Set Session  
            var x = HttpContext.Session.GetString("key"); // Get Value of Session
            return x;
        }
    }

}

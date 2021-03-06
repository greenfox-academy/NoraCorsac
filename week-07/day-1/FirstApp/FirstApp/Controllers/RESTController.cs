﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static long Counter = 0;
        [Route("greeting")]
        public IActionResult Greeting([FromQuery]string name)
        {
            Counter++;
            var hello = new Greeting(Counter, name);
            return new JsonResult(hello);
        }
    }
}
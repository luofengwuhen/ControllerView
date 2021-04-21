using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp4.Models;

namespace WebApp4.Controllers
{
   
    public class MyHomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MyHomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[Route("Test")]
        public IActionResult MyIndex()
        {
            return View();
        }

        public IActionResult MyPrivacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult MyError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
 
    }
}

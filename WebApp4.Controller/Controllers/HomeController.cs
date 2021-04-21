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
   //[Route("Test/[controller]/[Action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[Route("Test")]
        public IActionResult Index() //string id,string aa,string bb
        {
            //Console.WriteLine($"id:{id}--aa:{aa}---bb:{bb}");
            return View();
        }
        public IActionResult IndexHtml() 
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
 
    }
}

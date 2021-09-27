using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asp.net.mvc.Models;

namespace asp.net.mvc.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly ILogger<HelloWorldController> _logger;
        //private MusicModel myModel = new MusicModel();

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HelloWorld()
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

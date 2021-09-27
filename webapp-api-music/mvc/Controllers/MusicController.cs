using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asp.net.mvc.Models;


namespace mvc.Controllers
{
    public class MusicController : Controller
    {
        private readonly ILogger<MusicController> _logger;

        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

      

        public IActionResult unfaithful()
        {
            return View();
        }

        public IActionResult believer()
        {
            return View();
        }

          public IActionResult lovely()
        {
            return View();
        }

         public IActionResult trampoline()
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

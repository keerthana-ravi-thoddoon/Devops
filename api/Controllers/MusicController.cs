using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace jukebox.webapi.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class MusicController : ControllerBase
    {
        private Music myMusic = new Music();

        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        private readonly ILogger<MusicController> _logger;


        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1>Hello World!</h1>";
        }

        [HttpGet]
        [Route("[controller]/unfaithful")]      
          public String GetUnfaithful()
        {
            return myMusic.unfaithful;
        }

         [HttpGet]
        [Route("[controller]/trampoline")]      
          public String GetTrampoline()
        {
            return myMusic.trampoline;
        }

         [HttpGet]
        [Route("[controller]/believer")]      
          public String GetBeliever()
        {
            return myMusic.believer;
        }

          [HttpGet]
        [Route("[controller]/lovely")]      
          public String GetLovely()
        {
            return myMusic.lovely;
        }
    }
}

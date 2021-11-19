using System;
using System.Collections.Generic;
using System.Linq;
using FeaturedDeveloper.Models;
using FeaturedDeveloper.Helper;
using FeaturedDeveloper.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FeaturedDeveloper.Controllers
{
    public class FeaturedDevelopersController : Controller
    {

        private readonly IDeveloperUtility _utility;

        public ILogger<FeaturedDevelopersController> _logger { get; }

        public FeaturedDevelopersController(IDeveloperUtility utility, ILogger<FeaturedDevelopersController> logger)
        {
            _utility = utility;
            _logger = logger;
        }

        [HttpGet("api/FeaturedDevelopers")]
        public List<DeveloperFields> FeaturedDevelopers()
        {
            List<DeveloperFields> developers = _utility.getDeveloper();
            return developers;
        }

        [HttpGet("api/DeveloperofTheDay")]
        public DeveloperFields DeveloperofTheDay()
        {
            // _utility.getDeveloperOfDay();
            DeveloperFields developer = _utility.getDeveloperOfDay();
            return developer;
        }

        [HttpPost("api/EditDeveloperInfo/{DeveloperId}")]
        public String EditDeveloperInfo([FromBody] DeveloperFields fields, String DeveloperId)
        {
            String s = _utility.EditDeveloperInfo(DeveloperId, fields);
            return "ok";
        }

        [HttpDelete("api/DeleteDeveloper")]
        public String DeleteDeveloper(String DeveloperId)
        {
            String s = _utility.DeleteDeveloper(DeveloperId);
            return "ok";
        }


        [HttpPost("api/developer")]
        public String Developer([FromBody] DeveloperFields fields)
        {
            String s = _utility.createDeveloper(fields);
            return s;
        }
    }
}

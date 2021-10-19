using FeaturedDeveloper.Interfaces;
using FeaturedDeveloper.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaturedDeveloper.Controllers
{
    public class AuthenticationController : Controller
    {

        private readonly IDeveloperUtility _utility;

        public ILogger<AuthenticationController> _logger { get; }

        public bool IsAdmin;

        public AuthenticationController(IDeveloperUtility _Dutility, ILogger<AuthenticationController> ilogger)
        {
            _utility = _Dutility;
            _logger = ilogger;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Create([FromBody] User user)
        {

            return View();
        }
    }
}

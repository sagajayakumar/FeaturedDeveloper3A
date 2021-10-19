using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaturedDeveloper.Helper;
using Microsoft.Extensions.Logging;
using FeaturedDeveloper.Interfaces;
using FeaturedDeveloper.Models;

namespace FeaturedDeveloper.Data
{
    public class DevelopersRepository : IDeveloperRepository
    {
        private readonly DeveloperContext _DevelopersContext;
        private readonly ILogger<DeveloperUtility> _logger;

        public DevelopersRepository(DeveloperContext developerContext, ILogger<DeveloperUtility> logger)
        {
            _DevelopersContext= developerContext;
            _logger = logger;
        }
        public List<DeveloperFields> GetDevelopers()
        {
            List<DeveloperFields> q = _DevelopersContext.DeveloperFields.ToList();
            return q;
        }

        public DeveloperFields GetDeveloper()
        {
            var q = _DevelopersContext.DeveloperFields.FirstOrDefault();
            return q;
        }
    }
}

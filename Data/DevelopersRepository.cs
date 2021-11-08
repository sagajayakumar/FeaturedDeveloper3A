﻿using System;
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

        public DeveloperFields GetDeveloperById(String id)
        {
            var q = _DevelopersContext.DeveloperFields.Where(q => q.developerid == id).FirstOrDefault(); 
            return q;
        }

        public string updateLastShowed( DeveloperFields d)
        {
            var q = _DevelopersContext.DeveloperFields.Where(q => q.developerid == d.developerid).FirstOrDefault();
            if(q != null)
            {
                d.lastshowedon = DateTime.Now.ToString();
                _DevelopersContext.SaveChanges();
            }
            return "ok";
        }

        public bool EditDevelopers(DeveloperFields d)
        {
            var q = _DevelopersContext.DeveloperFields.Where(y => y.developerid == d.developerid).FirstOrDefault();
            if (q != null)
            {
                q.emailaddress = d.emailaddress;
                q.fullname = d.fullname;
                q.goals = d.goals;
                q.skills = d.skills;
                q.githuburl = d.githuburl;
                q.image = d.image;
                q.linkedinurl = d.linkedinurl;
                _DevelopersContext.SaveChanges();
            }
                return true;
        }
    }
}

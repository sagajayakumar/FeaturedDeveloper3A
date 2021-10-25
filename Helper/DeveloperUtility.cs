using System;
using System.Collections.Generic;
using FeaturedDeveloper.Interfaces;
using FeaturedDeveloper.Models;
using Microsoft.Extensions.Logging;

namespace FeaturedDeveloper.Helper
{
    public class DeveloperUtility : IDeveloperUtility
    {
        private readonly IDeveloperRepository _developersRepository;
        private readonly ILogger<DeveloperUtility> _logger;

        public DeveloperUtility(IDeveloperRepository developerRepository, ILogger<DeveloperUtility> logger)
        {
            _developersRepository = developerRepository;
            _logger = logger;
        }
        public DeveloperFields getDeveloper()
        {
            try
            {
                DeveloperFields developer = _developersRepository.GetDeveloper();
                return developer;
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message + " get developers error");
                return null;
            }
        }

        public DeveloperFields getDeveloperOfDay()
        {
            List<DeveloperFields> developers = _developersRepository.GetDevelopers();
            int size = developers.Count;
            Random random = new Random();
            DateTime currentDay = DateTime.Now;
            DateTime limit = DateTime.Now.AddDays(-7);
            DateTime lastShowed = DateTime.Now;
            DeveloperFields developer = null;
            int i = random.Next(0, size);
            for ( i =0; i < size; i++)
            {

                if (!string.IsNullOrEmpty(developers[i].lastshowedon))
                {
                    lastShowed = Convert.ToDateTime(developers[i].lastshowedon);
                }
                int diff = DateTime.Compare(lastShowed, limit);
                String l = lastShowed.ToString("MM/dd/yyyy");
                String c = currentDay.ToString("MM/dd/yyyy");
                if (l.Equals(c))
                {
                    developer = developers[i];
                    return developer;
                }
                if(diff < 0)
                {
                     developer = developers[i];
                    _developersRepository.updateLastShowed( developer);
                    return developer;
                }
            }
            return null;
        }

    }
}

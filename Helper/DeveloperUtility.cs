using System;
using System.Collections.Generic;
using FeaturedDeveloper.Interfaces;
using FeaturedDeveloper.Models;

namespace FeaturedDeveloper.Helper
{
    public class DeveloperUtility : IDeveloperUtility
    {
        private readonly IDeveloperRepository _developersRepository;

        public DeveloperUtility(IDeveloperRepository developerRepository)
        {
            _developersRepository = developerRepository;
        }
        public DeveloperFields getDeveloper()
        {
            DeveloperFields developer = _developersRepository.GetDeveloper();
            return developer;
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

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
            for (int i =0; i < size; i++)
            {
                int ran = random.Next(0, size);
                if (!string.IsNullOrEmpty(developers[ran].lastshowedon))
                {
                    lastShowed = Convert.ToDateTime(developers[ran].lastshowedon);
                }
                int diff = DateTime.Compare(lastShowed, limit);
                if(diff < 0)
                {
                     developer = developers[ran];
                    break;
                }
            }

            return developer;
        }

    }
}

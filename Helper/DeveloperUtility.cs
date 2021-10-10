using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaturedDeveloper.Data;
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

    }
}

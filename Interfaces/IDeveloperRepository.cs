using System;
using System.Collections.Generic;
using System.Linq;
using FeaturedDeveloper.Models;
using System.Threading.Tasks;

namespace FeaturedDeveloper.Interfaces
{
    public interface IDeveloperRepository
    {
        public List<DeveloperFields> GetDevelopers();

        public DeveloperFields GetDeveloper();

        public String updateLastShowed( DeveloperFields d);
    }
}

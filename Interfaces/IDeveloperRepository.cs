using System;
using System.Collections.Generic;
using System.Linq;
using FeaturedDeveloper.Models;
using System.Threading.Tasks;

namespace FeaturedDeveloper.Interfaces
{
    public interface IDeveloperRepository
    {
        public DeveloperFields GetDeveloper();
    }
}

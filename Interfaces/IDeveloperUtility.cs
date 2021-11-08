﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaturedDeveloper.Models;

namespace FeaturedDeveloper.Interfaces
{
   public interface IDeveloperUtility
    {
        public List<DeveloperFields> getDeveloper();

        public DeveloperFields getDeveloperOfDay();

        public String EditDeveloperInfo(String DeveloperId, DeveloperFields fields);
    }
}

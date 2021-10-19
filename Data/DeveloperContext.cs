using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using FeaturedDeveloper.Models;
using System.Threading.Tasks;

namespace FeaturedDeveloper.Data
{
    public class DeveloperContext : DbContext
    {
        public DbSet<DeveloperFields> DeveloperFields { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
            }
            base.OnConfiguring(optionsBuilder);
        }
        public DeveloperContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}

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
                optionsBuilder.UseNpgsql("Host=ec2-34-197-135-44.compute-1.amazonaws.com;Database=dfq2fu8j064n3b;Username=lglejpchfzsypl;Password=36eb12ce4f5bef2de9bca146cb21fd0d0d041044c42161136efad7183549c904");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public DeveloperContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}

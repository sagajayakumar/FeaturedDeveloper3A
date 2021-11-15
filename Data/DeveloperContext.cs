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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s541994",
                fullname = "Narsing Rao Nikitha Madhari",
                emailaddress = "nikithamn30@gmail.com",
                goals = " To become a data scientist",
                skills = " Java, SQL, Python, HTML",
                linkedinurl = "https://www.linkedin.com/in/nikitha-mn-42b2451aa/",
                githuburl = "https://github.com/NikithaMN-05",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQGFpMBjvgubmg/profile-displayphoto-shrink_200_200/0/1595495277739?e=1642032000&v=beta&t=A0-JrHOVgbP_uZeSpsMcpVa1eQLFRpcEW0fa_EX6UtM"
            });

            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542392",
                fullname = "Jaya Kumar Saga",
                emailaddress = "jayakumar1994@gmail.com",
                goals =  "Architect",
                skills = " webMethods",
                linkedinurl = "https://www.linkedin.com/in/jaya-kumar-saga/",
                githuburl = "https://github.com/sagajayakumar/sagajayakumar",
                image = "https://media-exp1.licdn.com/dms/image/C4E03AQGjXRymUrNNFA/profile-displayphoto-shrink_800_800/0/1517256401406?e=1641427200&v=beta&t=-c9Rr_dnNdgamQEXGaTPVomQnRjmvHjWbcBdvnBa3Lc"
            });

            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542269",
                fullname = "Shivaram Kothapally",
                emailaddress = "shivaramkothapally177@gmail.com",
                goals = "To became a leader in the software market",
                skills = "Html, java, Nodejs",
                linkedinurl = "https://www.linkedin.com/public-profile/settings?trk=d_flagship3_profile_self_view_public_profile",
                githuburl = "https://github.com/shivaramkothapally",
                image = null
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542264",
                fullname = "Rasagna Reddy Banda",
                emailaddress = "rasagna.reddyc@gmail.com",
                goals = "To work as a Frontend developer",
                skills = "Java, HTML, CSS, Java script",
                linkedinurl = "https://www.linkedin.com/in/rasagna-reddy-86a39a170/",
                githuburl = "https://github.com/Rasagna0409",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQG-GE4WVT27bw/profile-displayphoto-shrink_200_200/0/1624504209186?e=1642032000&v=beta&t=dQkmLARf1DFSfcC2CwIyczGzh9Z9krLvb5ChcAvUtFY"
            });
        }
    }
}

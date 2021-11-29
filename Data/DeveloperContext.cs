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
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s541903",
                fullname = "Pramod Reddy Gonegari",
                emailaddress = "gonegaripramodreddy@gmail.com",
                goals = "To build a product based startup and become an entrepreneur.",
                skills = "Mobile and Web Application Development, Vue, Ionic, Java, JavaScript .",
                linkedinurl = "https://www.linkedin.com/in/pramod-reddy-gonegari",
                githuburl = "https://github.com/pramod096",
                image = "test"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s541999",
                fullname = "Abhilash Ramavaram",
                emailaddress = "abhilashramavaram@gmail.com",
                goals = " Aspire to become bigdata architect",
                skills = "Java , Scala,spark,python, Hdfs, aws",
                linkedinurl = "https://www.linkedin.com/in/abhilash-ramavaram-30a23412b/",
                githuburl = "https://github.com/AbhiRam0099",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQEOzVpSzeum9w/profile-displayphoto-shrink_200_200/0/1597677122465?e=1642032000&v=beta&t=opTwgtNtRA0UpWf-o3yLVWXpyKNvAh9HNtLVjGzYOfg"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542413",
                fullname = "Vyshnavi Tadipaneni",
                emailaddress = "vyshnavi.t14@gmail.com",
                goals = "Software Engineer",
                skills = "Java, Html, CSS, JavaScript",
                linkedinurl = "N/A",
                githuburl = "https://github.com/vyshnavi1996",
                image = "https://st3.depositphotos.com/27847728/35061/v/600/depositphotos_350619560-stock-illustration-creative-letter-logo-vector-template.jpg"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s541904",
                fullname = "Kushal Satya Durgaji Katari",
                emailaddress = "kushalkatari@gmail.com",
                goals = "Want to become a Data Analyst.",
                skills = "Java, Python, HTML, CSS, JavaScript",
                linkedinurl = "https://www.linkedin.com/in/kushal-katari-b4276a149/",
                githuburl = "https://github.com/kushalkatari",
                image = "https://media-exp1.licdn.com/dms/image/C4E03AQFLutHJ-CrWqg/profile-displayphoto-shrink_200_200/0/1521137468763?e=1642032000&v=beta&t=8IKf2BSbLLqIpH79WlfZa3E_STbs4h86O_Kbe2RJNNo"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542403",
                fullname = "Akhil Kumar Reddy Mallepally",
                emailaddress = "mallepallyakhil@gmail.com",
                goals = "To be an MLOps Engineer",
                skills = "Python, Java, sql",
                linkedinurl = "https://www.linkedin.com/in/akhil-mallepally/",
                githuburl = "https://github.com/akhilmallepally/",
                image = "https://media-exp1.licdn.com/dms/image/C4D03AQH_y6N5M7reBg/profile-displayphoto-shrink_200_200/0/1623354701775?e=1642032000&v=beta&t=QqjLi5b2DKVke438uAqlWrqHGj-BQ-ZekDL0Ge85wic"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542298",
                fullname = "Sri Sathya Mamidala",
                emailaddress = "sathya.mamidala1@gmail.com",
                goals = "To become a backend java developer",
                skills = "Java, HTML",
                linkedinurl = "https://www.linkedin.com/in/sathya-mamidala-363b6a201/",
                githuburl = "https://github.com/srisathyamamidala",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQFrWpYYvoNhUA/profile-displayphoto-shrink_200_200/0/1607868548096?e=1642032000&v=beta&t=-7EFwMnrCT_yFXOFhs2KS3FMzX0xbAMZSDZRKPMY_Sc"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542271",
                fullname = "Tejaswi Reddy Nallavolu",
                emailaddress = "Tejaswireddynallavolu@gmail.com",
                goals = "To become a Front-end developer",
                skills = "HTML,CSS, JavaScript, Bootstrap, Java",
                linkedinurl = "https://www.linkedin.com/in/tejaswi-reddy-3a69a417b/",
                githuburl = "https://github.com/tejaswinallavolu",
                image = "https://media-exp1.licdn.com/dms/image/C4E03AQHcsgrpVSxBfg/profile-displayphoto-shrink_200_200/0/1633751606973?e=1642032000&v=beta&t=_KBSpIEkkBcUYjoILB5h2nRFvkhqfON-e85N82Qd8ow"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s541669",
                fullname = "Sanjay Saripalli",
                emailaddress = "sanjaysaripalli96@gmail.com",
                goals = "To be an Machine Learning Engineer",
                skills = " Python, Java, SQL",
                linkedinurl = "https://www.linkedin.com/in/sanjay-saripalli-57242b203/",
                githuburl = "https://github.com/sanjay-13",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQEYSZQDPDbktg/profile-displayphoto-shrink_200_200/0/1612546441551?e=1642032000&v=beta&t=5CEEDd3ufNPfb3vNvQjRsPALTUScv6sWRMM4l9_9c9w"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542000",
                fullname = "Naveen Tanuku",
                emailaddress = "ntanuku96@gmail.com",
                goals = "To be an entrepreneur ",
                skills = "Java, Power BI, ETL tools, Web technologies ",
                linkedinurl = "https://www.linkedin.com/in/naveen-tanuku/",
                githuburl = "https://github.com/NaveenTanuku",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQH4DVLFvdRFew/profile-displayphoto-shrink_200_200/0/1611015575996?e=1642032000&v=beta&t=0_qj4Ob1yHd0iAH1yvJ77S0l8wYPypf-HJFvN6MW2us"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542295",
                fullname = "Abhilash Dhumala",
                emailaddress = "dhumala.abhilash@gmail.com",
                goals = "To be a Front-end developer",
                skills = "Java, HTML, UFT.",
                linkedinurl = "https://www.linkedin.com/in/abhilash-dhumala-4b4ab9172/",
                githuburl = "https://github.com/Abhilash15",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQGMB5VMWf3Smg/profile-displayphoto-shrink_200_200/0/1614748373358?e=1642032000&v=beta&t=IJEJ2qxB9KqX7M3lq18PM0MOtN3zGRbiKwzvNn_M0bM"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542046",
                fullname = "Akanksha Sudhagoni",
                emailaddress = "akankshagoud.s@gmail.com",
                goals = "To become a Full-stack developer.",
                skills = "Html, Java, CSS.",
                linkedinurl = "https://www.linkedin.com/in/akanksha-goud-aa0ab8211/",
                githuburl = "https://github.com/S542046",
                image = "https://media-exp1.licdn.com/dms/image/C4E03AQH95DFFa0Mhpg/profile-displayphoto-shrink_200_200/0/1622045493003?e=1642032000&v=beta&t=E1cdYY0xwSLfq_zN-ahIYnhmr43zhC6sny768dChzLU"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542393",
                fullname = "Hemanth Venkata Reddy Telluri",
                emailaddress = "tellurireddy1998@gmail.com",
                goals = "Want to become a front end developer",
                skills = "Java,Python,HTML,CSS",
                linkedinurl = "N/A",
                githuburl = "https://github.com/hemanth8056",
                image = "N/A"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542041",
                fullname = "sai kiran reddy Enugala",
                emailaddress = "saikiranreddy0007@gmail.com",
                goals = "To become a cloud developer",
                skills = "Java , HTML , CSS",
                linkedinurl = "http://www.linkedin.com/in/sai-kiran-reddy-enugala-a06624138",
                githuburl = "https://github.com/saikiranreddyenugala",
                image = "N/A"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542409",
                fullname = "Harshavardhan Kurra",
                emailaddress = "harshavardhankurra4@gmail.com",
                goals = "Software Developer",
                skills = "Python, Java, Html, JavaScript",
                linkedinurl = "https://www.linkedin.com/in/harsha-kurra-b25b3b177/",
                githuburl = "https://github.com/harshakurra123",
                image = "https://media-exp1.licdn.com/dms/image/C5103AQHO2jMh_vVajA/profile-displayphoto-shrink_200_200/0/1545151738190?e=1642032000&v=beta&t=yosGUpBwyhnqlLQM_IAmIUGW2Z41qyTJnVVjStv5rKQ"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542423",
                fullname = "Rohit Reddy Chandupatla",
                emailaddress = "rohit.chandupatla@gmail.com",
                goals = "To become a QA Automation Engineer",
                skills = "Java, HTML, CSS, JavaScript, bootstrap.",
                linkedinurl = "https://www.linkedin.com/in/rohitchandupatla/",
                githuburl = "https://www.linkedin.com/in/rohitchandupatla/",
                image = "N/A"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542294",
                fullname = "Prasanna Arla",
                emailaddress = "prasannareddyarla@gmail.com",
                goals = "To become an software developer",
                skills = "Java, HTML, CSS, JavaScript",
                linkedinurl = "https://www.linkedin.com/in/prasanna-reddy-arla-0b0390222/",
                githuburl = "https://github.com/PRASANNAARLA",
                image = "N/A"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s541998",
                fullname = "MANOJ NUVVALA",
                emailaddress = "manoj.nuvvala@gmail.com",
                goals = "To start a new company.",
                skills = " Java python DevOps",
                linkedinurl = "N/A",
                githuburl = "https://github.com/manojnuvvala",
                image = "N/A"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542360",
                fullname = " Narendra Kumar Gunturu",
                emailaddress = "Gunturunarendra1998@gmail.com",
                goals = "To become a Full stack developer",
                skills = "Java, SQL, HTML, CSS, JavaScript",
                linkedinurl = "https://www.linkedin.com/in/narendra-kumar-gunturu-2b2892211/",
                githuburl = "https://www.linkedin.com/in/narendra-kumar-gunturu-2b2892211/",
                image = "N/A"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542406",
                fullname = "Sai Manideep Allu",
                emailaddress = "manideepml@gmail.com",
                goals = " To become a successful product manager.",
                skills = "Java, Python & ML tech stack",
                linkedinurl = "https://www.linkedin.com/in/sai-manideep-allu/",
                githuburl = "https://github.com/saimanideepallu",
                image = "https://media-exp1.licdn.com/dms/image/C5603AQG-lrBhIqknww/profile-displayphoto-shrink_200_200/0/1631167688058?e=1642032000&v=beta&t=1tRZX04dCR4BAh9KYKdgMxdbo8Hz9T_NG2YPpRpdOi4"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s541900",
                fullname = "Amulya Baddam",
                emailaddress = "amulyareddybaddam@gmail.com",
                goals = "To work as a Full Stack Developer",
                skills = "Java, HTML, JavaScript",
                linkedinurl = "https://www.linkedin.com/in/amulya-reddy-7b9a20211/",
                githuburl = "https://github.com/amulyareddybaddam",
                image = "N/A"
            });
            modelBuilder.Entity<DeveloperFields>().HasData(new DeveloperFields
            {
                developerid = "s542048",
                fullname = "Vivek Tadiparthi",
                emailaddress = "tadsaivivekreddy@gmail.com",
                goals = "Aspire to be an App developer and have a startup of my own.",
                skills = "Java, Python, Android development",
                linkedinurl = "https://www.linkedin.com/in/vivektadiparthi/",
                githuburl = "https://github.com/vivektadiparthi",
                image = "https://media-exp1.licdn.com/dms/image/C4D03AQEmUX5ba_R4gA/profile-displayphoto-shrink_200_200/0/1610239019881?e=1642032000&v=beta&t=KYrRELeMPmNmYRiPZCgDa2Eh8bTBrEv2swjNjF0In-g"
            });
        }
    }
}

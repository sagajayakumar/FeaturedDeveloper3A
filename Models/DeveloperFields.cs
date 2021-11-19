using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeaturedDeveloper.Models
{
    [Serializable]
    [Table("developers")]
    public class DeveloperFields
    {

        [Key]
        public String developerid { get; set; }
        
        public String fullname { get; set; }

        public String emailaddress { get; set; }

        public String goals { get; set; }

        public String skills { get; set; }

        public String linkedinurl { get; set; }

        public String githuburl { get; set; }

        public String image { get; set; }

        //public String createdOn { get; set; }

        public String lastshowedon { get; set; }

        public Boolean isDeleted { get; set; }


    }
}

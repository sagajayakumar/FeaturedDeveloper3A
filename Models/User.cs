using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FeaturedDeveloper.Models
{
    public class User
    {
        [DefaultValue("")]
        public String UserName { get; set; }
        [DefaultValue("")]
        public String Password { get; set; }
        [DefaultValue("")]
        public String Email { get; set; }
    }
}

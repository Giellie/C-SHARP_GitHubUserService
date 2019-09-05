using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitHubUserService.Models
{
    public class GitHubUser
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }        
        public string type { get; set; }
        public string site_admin { get; set; }
    }
}
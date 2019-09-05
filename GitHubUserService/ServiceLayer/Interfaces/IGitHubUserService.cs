using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using GitHubUserService.Models;

namespace GitHubUserService
{ 
    public interface IGitHubUserService
    {
        Task<GitHubUser> GetUserDetails(string name);
    }
}
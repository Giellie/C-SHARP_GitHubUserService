using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using GitHubUserService.Models;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Web.Http.Description;

namespace GitHubUserService
{
    public class GitHubUserController : ApiController
    {
        private readonly IGitHubUserService _gitHubUserService;

        public GitHubUserController(IGitHubUserService gitHubUserService)
        {
            _gitHubUserService = gitHubUserService;
        }        

        [ResponseType(typeof(GitHubUser))]
        public Task<GitHubUser> Get(string userName)
        {
            var users = _gitHubUserService.GetUserDetails(userName);
            if(users == null)
            {
                return null;
            }
            return users;
        }
    }

}

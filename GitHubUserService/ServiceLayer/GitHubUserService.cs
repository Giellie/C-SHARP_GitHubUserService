using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using GitHubUserService.Models;
using Newtonsoft.Json;

namespace GitHubUserService
{
    public class GitHubUserService : IGitHubUserService
    {
        public Task<GitHubUser> GetUserDetails(string userName)
        {
            //https://api.github.com/
            //https://api.github.com/users/

            string url = "https://api.github.com/users/" + userName;

            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.UserAgent = "Anything";
            webRequest.ServicePoint.Expect100Continue = false;

            using (StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                string reader = responseReader.ReadToEnd();
                var jsonobj = JsonConvert.DeserializeObject<GitHubUser>(reader);
                return Task.FromResult(jsonobj);
            }
        }
    }
}
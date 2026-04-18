using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Octokit;
using System.Threading.Tasks;

namespace DogAndPoint.Logic
{
    internal class GitHubInfo
    {
        public static async Task<(string Name, string Version)> GitHubInformation()
        {
            var client = new GitHubClient(new ProductHeaderValue("DogAndPoint"));
            string owner = "blakewai";
            string reponame = "DogAndPoint";

            try
            {
                var repo = await client.Repository.Get(owner, reponame);

                string version = "v0.0.0";
                try
                {
                    var reliserepo = await client.Repository.Release.GetLatest(owner, reponame);
                    version = reliserepo.TagName;
                }
                catch (NotFoundException)
                {
                    version = "Нет активных релизов";
                }

                return (repo.Name, version);
            }
            catch (Exception)
            {
                return ("Ошибка доступа", "---");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Octokit;
using System.Threading.Tasks;

namespace DogAndPower.Logic
{
    internal class GitHubInfo
    {
        public static async Task<MyInfo> GitHubInformation()
        {
            var client = new GitHubClient(new ProductHeaderValue("DogAndPaintApp"));

            // 1. Получаем инфо о репозитории (это должно работать всегда)
            var repo = await client.Repository.Get("blakewai", "DogAndPaint");

            string version = "0.0.0";
            try
            {
                // 2. Пытаемся получить релиз. Если его нет — просто идем дальше
                var latest = await client.Repository.Release.GetLatest("blakewai", "DogAndPaint");
                version = latest.TagName;
            }
            catch (NotFoundException)
            {
                version = "Бета (нет релизов)";
            }

            return new MyInfo { Name = repo.Name, Version = version };
        }
    }
}

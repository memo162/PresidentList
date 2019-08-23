using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PresidentsList.Domain.Models;
using PresidentsList.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace PresidentsList.Infrastructure.Resources.PresidentResources
{
    public class PresidentResource : IPresidentResources
    {

        private readonly IConfiguration _configuration;

        public PresidentResource(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<President> GetFromJson()
        {
            var jsonPath = _configuration.GetSection("JsonPresidentsPath");
            using (StreamReader r = new StreamReader(jsonPath.Value))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<President>>(json);
            }
        }
    }
}

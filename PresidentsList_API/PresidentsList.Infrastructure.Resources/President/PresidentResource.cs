using Newtonsoft.Json;
using PresidentsList.Domain.Models;
using PresidentsList.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PresidentsList.Infrastructure.Resources.PresidentResources
{
    public class PresidentResource : IPresidentResources
    {
        public List<President> GetFromJson()
        {
            using (StreamReader r = new StreamReader("resources/presidents.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<President>>(json);
            }
        }
    }
}

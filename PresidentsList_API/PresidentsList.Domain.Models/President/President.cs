
using Newtonsoft.Json;
using PresidentsList.Domain.Models.Generics;
using System;

namespace PresidentsList.Domain.Models
{
    public class President : ModelBase
    {
        [JsonProperty("President")]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }

        [JsonProperty("Death day")]
        public DateTime? DeathDay { get; set; }

        [JsonProperty("Death place")]
        public string DeathPlace { get; set; }
        public string UrlMoreInfo { get; set; }
        public string UrlPlaceInfo { get; set; }
    }
}

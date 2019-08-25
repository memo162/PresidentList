
using Newtonsoft.Json;
using PresidentsList.Domain.Models.Generics;
using System;

namespace PresidentsList.Domain.Models
{
    public class President : ModelBase
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }
        public DateTime? DeathDay { get; set; }
        public string DeathPlace { get; set; }
        public string UrlMoreInfo { get; set; }
        public string UrlPlaceInfo { get; set; }
    }
}

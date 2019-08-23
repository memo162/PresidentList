
using System.Collections.Generic;
using System.Linq;
using PresidentsList.Domain.Interfaces.PresidentService;
using PresidentsList.Domain.Models;
using PresidentsList.Infrastructure.Interfaces;

namespace PresidentsList.Domain.Services.PresidentService
{
    public class PresidentService : IPresidentService
    {
        private readonly IPresidentResources _presidentResource;

        public PresidentService(IPresidentResources presidentResource)
        {
            _presidentResource = presidentResource;
        }

        public List<President> Get()
        {
            return _presidentResource.GetFromJson();
        }

        public List<President> GetOrderByAsc()
        {
            return _presidentResource.GetFromJson().OrderBy(x => x.Name).ToList();
        }

        public List<President> GetOrderByDesc()
        {
            return _presidentResource.GetFromJson().OrderByDescending(x => x.Name).ToList();
        }
    }
}

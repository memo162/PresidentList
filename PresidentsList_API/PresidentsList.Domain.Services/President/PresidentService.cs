
using System.Collections.Generic;
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
            return new List<President>();
        }

        public List<President> GetOrderByDesc()
        {
            return new List<President>();
        }
    }
}

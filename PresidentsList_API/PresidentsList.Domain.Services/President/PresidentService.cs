
using System.Collections.Generic;
using PresidentsList.Domain.Interfaces.PresidentService;
using PresidentsList.Domain.Models;

namespace PresidentsList.Domain.Services.PresidentService
{
    public class PresidentService : IPresidentService
    {
        public List<President> Get()
        {
            return new List<President>();
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

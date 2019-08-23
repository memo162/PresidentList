using PresidentsList.Application.Interfaces;
using PresidentsList.Domain.Enumerators;
using PresidentsList.Domain.Interfaces.PresidentService;
using PresidentsList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Applications.Services.PresidentApplication
{
    public class PresidentApplication : IPresidentApplication
    {
        private readonly IPresidentService _presidentService;

        public PresidentApplication(IPresidentService presidentService)
        {
            _presidentService = presidentService;
        }

        public List<President> Get()
        {
            return _presidentService.Get();
        }

        public List<President> Get(string orderBy)
        {
            if(!string.IsNullOrEmpty(orderBy))
            {
                if (orderBy.ToUpper().Equals(OrderBy.Ascending))
                {
                    return _presidentService.GetOrderByAsc();
                }

                else if (orderBy.ToUpper().Equals(OrderBy.Descending))
                {
                    return _presidentService.GetOrderByDesc();
                }
            }

            return new List<President>();
        }
    }
}

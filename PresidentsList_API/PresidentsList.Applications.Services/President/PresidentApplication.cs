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

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PresidentApplication(IPresidentService presidentService)
        {
            _presidentService = presidentService;
        }

        public List<President> Get()
        {
            try
            {
                return _presidentService.Get();
            }
            catch (Exception ex)
            {
                log.Error(string.Concat("Get() President application Error:: ", ex.Message, ex.StackTrace));
                return new List<President>();
            }
        }

        public List<President> Get(string orderBy)
        {
            try
            {
                if (!string.IsNullOrEmpty(orderBy))
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
            catch (Exception ex)
            {
                log.Error(string.Concat("Get(OrderBy) President application Error:: ", ex.Message, ex.StackTrace));
                return new List<President>();
            }
        }
    }
}

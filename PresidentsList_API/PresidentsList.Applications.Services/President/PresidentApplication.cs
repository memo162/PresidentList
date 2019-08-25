using Newtonsoft.Json;
using PresidentsList.Application.Interfaces;
using PresidentsList.Domain.Enumerators;
using PresidentsList.Domain.Interfaces.PresidentService;
using PresidentsList.Domain.Models;
using PresidentsList.Domain.Models.Generics;
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

        public Result<List<President>> Get()
        {
            var result = new Result<List<President>>();

            try
            {
                result.Data = _presidentService.Get();
                return result;
            }
            catch (Exception ex)
            {
                log.Error(string.Concat("Get() President application Error:: ", ex.Message, ex.StackTrace));
                result.Error.Code = ErrorCodes.InternalError;
                result.Error.Message = string.Concat(ErrorMessage.InternalError, " :: ", ex.Message);
                result.Error.Type = ErrorTypes.Error;
                return result;
            }
        }

        public Result<List<President>> Get(string orderBy)
        {
            var result = new Result<List<President>>();

            try
            {
                if (!string.IsNullOrEmpty(orderBy))
                {
                    if (orderBy.ToUpper().Equals(OrderBy.Ascending))
                    {
                        result.Data = _presidentService.GetOrderByAsc();
                    }

                    else if (orderBy.ToUpper().Equals(OrderBy.Descending))
                    {
                        result.Data = _presidentService.GetOrderByDesc();
                    }
                    else
                    {
                        result.Error.Code = ErrorCodes.UnrecognizedCommand;
                        result.Error.Message = ErrorMessage.UnrecongnizeOrderByCommand;
                        result.Error.Type = ErrorTypes.Info;
                    }
                }

                var test = JsonConvert.SerializeObject(result.Data);

                return result;
            }
            catch (Exception ex)
            {
                log.Error(string.Concat("Get(OrderBy) President application Error:: ", ex.Message, ex.StackTrace));
                result.Error.Code = ErrorCodes.InternalError;
                result.Error.Message = string.Concat(ErrorMessage.InternalError, " :: " ,ex.Message);
                result.Error.Type = ErrorTypes.Error;
                return result;
            }
        }
    }
}

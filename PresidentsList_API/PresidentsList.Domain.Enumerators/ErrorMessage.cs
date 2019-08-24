using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Domain.Enumerators
{
    public static class ErrorMessage
    {
        public const string UnrecongnizeOrderByCommand = "orderby paramameter not recognized, try to 'asc' for ascendent or 'desc' for descendent";
        public const string InternalError = "Internal Error, try later";
    }
}

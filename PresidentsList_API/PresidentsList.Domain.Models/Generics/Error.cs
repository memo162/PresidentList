using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Domain.Models.Generics
{
    public class Error
    {
        public int? Code { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
    }
}

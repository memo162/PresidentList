using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Domain.Models.Generics
{
   public class Result<T>
    {
        public Result() {
            Error = new Error();
        }

        public T Data { get; set; }
        public Error Error { get; set; }
        public bool HasError()
        {
            return !string.IsNullOrEmpty(this.Error.Message) || this.Error.Code != null;
        }
    }
}

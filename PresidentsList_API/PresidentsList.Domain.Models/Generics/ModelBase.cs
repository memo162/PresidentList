using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Domain.Models.Generics
{
    public class ModelBase
    {
        public int Id { get; set; }

        public int IdCreateUser { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}

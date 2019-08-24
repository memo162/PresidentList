using PresidentsList.Domain.Models;
using PresidentsList.Domain.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Application.Interfaces
{
    public interface IPresidentApplication
    {
        Result<List<President>> Get();

        Result<List<President>> Get(string orderBy);
    }
}

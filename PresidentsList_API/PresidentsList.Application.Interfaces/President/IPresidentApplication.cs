using PresidentsList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Application.Interfaces
{
    public interface IPresidentApplication
    {
        List<President> Get();

        List<President> Get(string orderBy);
    }
}

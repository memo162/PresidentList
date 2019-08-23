using PresidentsList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Domain.Interfaces.PresidentService
{
    public interface IPresidentService
    {
        List<President> Get();

        List<President> GetOrderByAsc();

        List<President> GetOrderByDesc();
    }
}

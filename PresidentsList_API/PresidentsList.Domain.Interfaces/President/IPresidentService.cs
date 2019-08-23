using PresidentsList.Domain.Models;
using System.Collections.Generic;

namespace PresidentsList.Domain.Interfaces.PresidentService
{
    public interface IPresidentService
    {
        List<President> Get();

        List<President> GetOrderByAsc();

        List<President> GetOrderByDesc();
    }
}

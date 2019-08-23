
using PresidentsList.Domain.Models;
using System.Collections.Generic;

namespace PresidentsList.Infrastructure.Interfaces
{
    public interface IPresidentResources
    {
        List<President> GetFromJson();
    }
}

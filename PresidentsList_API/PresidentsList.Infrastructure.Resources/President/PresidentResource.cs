using PresidentsList.Domain.Models;
using PresidentsList.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Infrastructure.Resources.President
{
    public class PresidentResource : IPresidentResources
    {
        public List<Domain.Models.President> GetFromJson()
        {
            throw new NotImplementedException();
        }
    }
}

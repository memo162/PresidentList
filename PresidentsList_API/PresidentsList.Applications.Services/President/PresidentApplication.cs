using PresidentsList.Application.Interfaces;
using PresidentsList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentsList.Applications.Services.PresidentApplication
{
    public class PresidentApplication : IPresidentApplication
    {
        public List<President> Get()
        {
            throw new NotImplementedException();
        }

        public List<President> Get(string orderBy)
        {
            throw new NotImplementedException();
        }
    }
}

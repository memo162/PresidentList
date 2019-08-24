using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresidentsList.Application.Interfaces;
using PresidentsList.Domain.Models;
using PresidentsList.Domain.Models.Generics;

namespace PresidentsList_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresidentsController : ControllerBase
    {
    
        private readonly IPresidentApplication _presidentApplication;

        public PresidentsController(IPresidentApplication presidentApplication)
        {
            _presidentApplication = presidentApplication;
        }

        // GET: api/Presidents
        [HttpGet]
        public Result<List<President>> Get()
        {
            return _presidentApplication.Get();
        }

        // GET: api/Presidents/orderBy=desc
        [HttpGet("orderby={orderBy}", Name = "Get")]
        public Result<List<President>> Get(string orderBy)
        {
            return _presidentApplication.Get(orderBy);
        }
    }
}

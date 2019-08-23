using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresidentsList.Application.Interfaces;
using PresidentsList.Domain.Models;

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
        public IEnumerable<President> Get()
        {
            return _presidentApplication.Get();
        }

        // GET: api/Presidents/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Presidents
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Presidents/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

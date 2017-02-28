using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF6;
using EF6.Model;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebApiWithAngular.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly WebApiContext _context;

        public ValuesController(WebApiContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public void Index()
        {
            Response.Redirect("..\\Index.html");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

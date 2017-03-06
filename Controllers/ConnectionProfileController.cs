using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreData.Resources;
using Microsoft.AspNetCore.Mvc;

namespace CoreData.Controllers
{
    [Route("api/[controller]")]
    public class ConnectionProfileController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<ConnectionProfile> Get()
        {
            var result = new List<ConnectionProfile>();
            result.Add(new ConnectionProfile{Id = 1, ProfileName = "Test1" });
            result.Add(new ConnectionProfile{Id = 2, ProfileName = "Test2"});
            return result;
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

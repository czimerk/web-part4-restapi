using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> Values { get; set; } = new List<string>{ "value1", "value2" };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (Values.Count > id)
            {
                return Values[id];
            }
            else {
                return BadRequest("wrong id");
            }
           
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

            Values.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            if (Values.Count > id)
            {
                Values[id] = value;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Values.RemoveAt(id);
        }
    }
}

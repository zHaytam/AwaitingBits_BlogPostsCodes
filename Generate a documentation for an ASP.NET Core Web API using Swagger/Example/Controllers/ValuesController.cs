using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Example.Controllers
{
    [SwaggerTag("Requests about values")]
    [Route("api/[action]")]
    public class ValuesController : Controller
    {

        /// <summary>
        /// Gets two values.
        /// </summary>
        [HttpGet]
        [SwaggerOperation(Summary = "Gets two values", Description = "Gets two hardcoded values")]
        [SwaggerResponse(200, "I guess everything worked")]
        [SwaggerResponse(400, "BAD REQUUUUEST")]
        public IEnumerable<string> Values()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Gets a value.
        /// </summary>
        /// <param name="id">The id !!</param>x
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Posts a value.
        /// </summary>
        /// <param name="value">The value !!</param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Puts a value.
        /// </summary>
        /// <param name="id">The id !!</param>
        /// <param name="value">The value !!</param>
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Deletes an entry.
        /// </summary>
        /// <param name="id">The id !!</param>
        [HttpDelete]
        public void Delete(int id)
        {
        }

    }
}
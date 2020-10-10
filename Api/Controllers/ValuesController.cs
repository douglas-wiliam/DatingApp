using System.Collections.Generic;
using System.Linq;
using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Value>> Get()
        {
            return _context.Values;
        }


        [HttpGet("{id}")]
        public ActionResult<Value> Get(int id)
        {
            return _context.Values.FirstOrDefault(v => v.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
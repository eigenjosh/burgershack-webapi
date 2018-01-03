using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class BurgersController : Controller
    {
        //AGAIN VERY BAD!!!!!!
        public List<Burger> Burgers = Program.Burgers;

        // GET api/values
        [HttpGet]
        public IEnumerable<Burger> Get()
        {
            return Program.Burgers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Burger Get(int id)
        {
            return Program.Burgers.FirstOrDefault(b => b.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Burger> Post([FromBody]Burger burger)
        {
            Program.Burgers.Add(burger);
            return Program.Burgers;
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

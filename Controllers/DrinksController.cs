using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class DrinksController : Controller
    {
        //AGAIN VERY BAD!!!!!!
        public List<Drink> Drinks = Program.Drinks;

        // GET api/values
        [HttpGet]
        public IEnumerable<Drink> Get()
        {
            return Program.Drinks;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Drink Get(int id)
        {
            return Program.Drinks.FirstOrDefault(b => b.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Drink> Post([FromBody]Drink drink)
        {
            Program.Drinks.Add(drink);
            return Program.Drinks;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            Program.Drinks.RemoveAt(id);
            Program.Drinks.Add();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

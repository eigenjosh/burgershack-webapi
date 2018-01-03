using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        //AGAIN VERY BAD!!!!!!
        public Menu Menu = new Menu()
        {
            Burgers = Program.Burgers,
            Sides = Program.Sides,
            Drinks = Program.Drinks
        };
    
        // GET api/values
        [HttpGet]
        public Menu Get()
        {
            return Menu;
        }
    }
}

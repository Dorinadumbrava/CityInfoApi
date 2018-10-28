using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Produces("application/json")]
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet]
        public ActionResult GetCities()
        {
            var result = _list;
            return Ok(result);
        }


        static List<object> _list = new List<object>()
                {
                new {id = 1, Name = "New York city" },
                new {id = 2, Name = "Antwerp" }
                };
    }
}

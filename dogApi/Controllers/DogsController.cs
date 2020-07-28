using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApi.Controllers
{
    public class DogsController : Controller
    {
        [HttpGet("dogs")]
        public IActionResult GetDogs()
        {
            return Ok();
        }
    }
}

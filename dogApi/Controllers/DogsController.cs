using DogApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogApi.Controllers
{
    public class DogsController : Controller
    {
        private IDogService _dogService;
        public DogsController(IDogService dogService) 
        {
            _dogService = dogService;
        }

        [HttpGet("dogs")]
        public IActionResult GetDogs()
        {
            var result = _dogService.GetAllDogs();
            return Ok(result);
        }

        [HttpGet("dog/{breed}")]
        public IActionResult GetDog([FromRoute] string breed)
        {
            var result = _dogService.GetDog(breed);
            return Ok(result);
        }
    }
}

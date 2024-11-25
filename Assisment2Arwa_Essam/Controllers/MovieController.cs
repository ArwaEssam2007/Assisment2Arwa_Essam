using Assisment2Arwa_Essam.DTOs;
using Assisment2Arwa_Essam.Repository.Cinema;
using Assisment2Arwa_Essam.Repository.Movie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assisment2Arwa_Essam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public MovieController(IMove_Repo move_Repo)
        {
            move_Repo = _Repo;
        }
        protected IMove_Repo _Repo;

        [HttpGet] public IActionResult GetAllData()
        {
          var res = _Repo.GetMovies();
            if(res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }
        [HttpGet("Get by id")]
        public IActionResult Get(int id)
        {
            _Repo.GetById(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddMovies(MovieDto movie)
        {
            _Repo.AddMovie(movie);
            return Ok();
        }
    }
}

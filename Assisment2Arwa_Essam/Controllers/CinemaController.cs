using Assisment2Arwa_Essam.DTOs;
using Assisment2Arwa_Essam.Repository.Cinema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assisment2Arwa_Essam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        protected ICenemaRepo _cenemaRepo;
        public CinemaController(ICenemaRepo cenemaRepo)
        {
            cenemaRepo = _cenemaRepo;
        }
        [HttpGet("get all cinema")]
        public IActionResult GetAll()
        {
            var res = _cenemaRepo.GetAll();
           if(res!=null)
            {
                return Ok(res);
            }
            return BadRequest();
        }

        [HttpPut("update cinema")]
        public IActionResult updatecinema(CinemaDto cinemaDto , int id)
        {
          _cenemaRepo.UpdateAll(cinemaDto , id);
            return Ok();
        }

        [HttpPost("AddCinema")]
        public IActionResult AddCinema(CinemaDto cinemaDto)
        {
            _cenemaRepo.AddCinema(cinemaDto);
            return Ok();    
        }
        
       
    }
}

using BookTheShowBLL.services;
using BookTheShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System;

namespace MovieAppCoreApii.Controllers
{
    [Route("api/[controller]")] //route means url this produces local host (route)  api beacause it is service application 
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieSevice _movieService;

        public MovieController(MovieSevice movieService)
        {
            _movieService = movieService;
        }
         
        
        [HttpGet("GetMovies")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Moviev> GetMovies()
        {
            return _movieService.GetMovies();
        }



        [HttpPost("AddMovie")]

        public IActionResult AddMovie([FromBody]Moviev movie) //from body it will take input
        {
            _movieService.AddMovie(movie);
            return Ok("Movie created successfully!!");//Ok will give 200 code in runtime
        }

        [HttpDelete("DeleteMovie")]

        public IActionResult DeleteMovie(int movieId)  //iactionresult it can return anything like integer string json etc
        {
            _movieService.DeleteMovie(movieId);

            return Ok("Movie Deleted successfully!!");


        }

        [HttpPut("UpdateMovie")]
        
        public IActionResult UpdateMovie([FromBody] Moviev movie)
        {
            _movieService.UpdateMovie(movie);
            return Ok("Movie updated successfully!!");
        }

    }
}

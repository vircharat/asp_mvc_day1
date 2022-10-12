using BookTheShowBLL.services;
using BookTheShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieAppCoreApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatreController : ControllerBase
    {
        private TheatreService _theatreService;

        public TheatreController(TheatreService theatreService)
        {
           _theatreService = theatreService;
        }


        [HttpGet("GetTheatres")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Theatrev> GetTheatres()
        {
            return _theatreService.GetTheatres();
        }



        [HttpPost("AddTheatre")]

        public IActionResult AddTheatre([FromBody] Theatrev theatrev) //from body it will take input
        {
            _theatreService.AddTheatre(theatrev);
            return Ok("Theatre created successfully!!");//Ok will give 200 code in runtime
        }

        [HttpDelete("DeleteTheatre")]

        public IActionResult DeleteTheatre(int theatreId)  //iactionresult it can return anything like integer string json etc
        {
            _theatreService.DeleteTheatre(theatreId);

            return Ok("ShowTime Deleted successfully!!");


        }

        [HttpPut("UpdateTheatre")]

        public IActionResult UpdateTheatre([FromBody] Theatrev theatrev)
        {
            _theatreService.UpdateTheatre(theatrev);
            return Ok("Theatre updated successfully!!");
        }
    }
}

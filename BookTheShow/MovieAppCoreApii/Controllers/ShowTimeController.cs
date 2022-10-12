using BookTheShowBLL.services;
using BookTheShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieAppCoreApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimeController : ControllerBase
    {
        private ShowTimeService _showTimeService;

        public ShowTimeController(ShowTimeService showTimeService)
        {
            _showTimeService = showTimeService;
        }


        [HttpGet("GetShows")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<ShowTimev> GetShows()
        {
            return _showTimeService.GetShowTimes();
        }



        [HttpPost("AddShow")]

        public IActionResult AddShow([FromBody] ShowTimev showTimev) //from body it will take input
        {
            _showTimeService.AddShowTime(showTimev);
            return Ok("Show Time created successfully!!");//Ok will give 200 code in runtime
        }

        [HttpDelete("DeleteShow")]

        public IActionResult DeleteShow(int showId)  //iactionresult it can return anything like integer string json etc
        {
            _showTimeService.DeleteShowTime(showId);    

            return Ok("ShowTime Deleted successfully!!");


        }

        [HttpPut("UpdateShow")]

        public IActionResult UpdateShow([FromBody] ShowTimev showTimev)
        {
            _showTimeService.UpdateShowTime(showTimev);
            return Ok("Show Time updated successfully!!");
        }

    }
}

using BookTheShowBLL.services;
using BookTheShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieAppCoreApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookinggController : ControllerBase
    {
        private BookingService _bookingService;

        public BookinggController(BookingService bookingService)
        {
            _bookingService=bookingService;
        }


        [HttpGet("GetBooking")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Booking> GetBooking()
        {
            return _bookingService.GetBookings();
        }



        [HttpPost("AddBooking")]

        public IActionResult AddBooking([FromBody] Booking booking) //from body it will take input
        {
            _bookingService.AddBooking(booking);
            return Ok("Booking created successfully!!");//Ok will give 200 code in runtime
        }

        [HttpDelete("DeleteBooking")]

        public IActionResult DeleteBooking(int bookingId)  //iactionresult it can return anything like integer string json etc
        {
           _bookingService.DeleteBooking(bookingId);

            return Ok("Booking Deleted successfully!!");


        }

        [HttpPut("UpdateBooking")]

        public IActionResult UpdateBooking([FromBody] Booking booking)
        {
            _bookingService.UpdateBooking(booking);
            return Ok("Booking updated successfully!!");
        }
    }
}

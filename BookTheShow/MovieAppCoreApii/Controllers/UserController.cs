using BookTheShowBLL.services;
using BookTheShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieAppCoreApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }


        [HttpGet("GetUsers")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Userv> GetUsers()
        {
            return _userService.GetUsers();
        }



        [HttpPost("AddUser")]

        public IActionResult AddUser([FromBody] Userv userv) //from body it will take input
        {
            _userService.AddUser(userv);    
            return Ok("User created successfully!!");//Ok will give 200 code in runtime
        }

        [HttpDelete("DeleteUser")]

        public IActionResult DeleteUser(int userId)  //iactionresult it can return anything like integer string json etc
        {
            _userService.DeleteUser(userId);

            return Ok("User Deleted successfully!!");


        }

        [HttpPut("UpdateUser")]

        public IActionResult UpdateUser([FromBody] Userv userv)
        {
            _userService.UpdateUser(userv);
            return Ok("User updated successfully!!");
        }
    }
}

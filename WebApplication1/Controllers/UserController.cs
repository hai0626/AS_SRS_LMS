
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Interface;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
     
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        [HttpGet("get-all-user")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _user.GetAllUser();
            return Ok(users);
        }
        [HttpPost("register")]
        public IActionResult Register(UserRequest request)
        {
            _user.Register(request);
            return Ok(new { message = "User created" });
        }
    }
}

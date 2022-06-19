
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Interface;
using WebApplication1.Model;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
     
        private readonly IUClass _user;
        public UserController(IUClass user)
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
            var register = _user.Register(request);
            if (register == 0)
            {
                return BadRequest(new { message = "email da ton tai" });
            }
            return Ok(new { message = "dang ki thanh cong" });
        }
        [HttpGet("login")]
        public IActionResult Login(string email, string pass)
        {
            int login = _user.Login( email, pass);
            if(login == 0)
            {
                return BadRequest(new { message = "mat khau hoac tai khoan khong dung" });
            }
            return Ok(new { message = "dang nhap thanh cong" });
        }
        [HttpPost("forgot-password")]
        public IActionResult Forgot(string email, string pass, string newpass)
        {
            int forgot = _user.ForgotPassword( email,  pass,  newpass);
            if (forgot == 0)
            {
                return BadRequest(new { message = "tai khoan khong ton tai" });
            }
            return Ok(new { message = "doi mat khau thanh cong" });
        }
    }
}

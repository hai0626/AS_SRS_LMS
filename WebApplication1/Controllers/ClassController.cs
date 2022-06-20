using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Model;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClass _class;
        public ClassController(IClass cls)
        {
            _class = cls;
        }
        [HttpGet("get-all-user")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var cls = _class.GetAllClass();
            return Ok(cls);
        }
        [HttpPost("add-class")]
        public IActionResult AddClass(ClassRequest request)
        {
            var add = _class.AddClass(request);
            if (add == 0)
            {
                return BadRequest(new { message = "ten lop da ton tai" });
            }
            return Ok(new { message = "tao lop thanh cong" });
        }
        
        [HttpDelete("delete-class")]
        public IActionResult DeleteClass(int id)
        {
            int login = _class.DeleteClass(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }
        [HttpPost("update-class")]
        public IActionResult UpdateClass(int id, ClassRequest rq)
        {
            int login = _class.UpdateClass(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
    }
}

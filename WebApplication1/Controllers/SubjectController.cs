using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Model;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubject _subject;
        public SubjectController(ISubject sub)
        {
            _subject = sub;
        }
        [HttpGet("get-all-subject")]
        public ActionResult<IEnumerable<Subject>> GetUsers()
        {
            var cls = _subject.GetAllSubject();
            return Ok(cls);
        }
        [HttpPost("add-subject")]
        public IActionResult AddClass(SubjectRequest request)
        {
            var add = _subject.AddSubject(request);
            if (add == 0)
            {
                return BadRequest(new { message = "ten lop da ton tai" });
            }
            return Ok(new { message = "tao lop thanh cong" });
        }
        
        [HttpDelete("delete-subject")]
        public IActionResult DeleteClass(int id)
        {
            int login = _subject.DeleteSubject(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }
        [HttpPost("update-subject")]
        public IActionResult UpdateClass(int id, SubjectRequest rq)
        {
            int login = _subject.UpdateSubject(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
    }
}

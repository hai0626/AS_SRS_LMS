using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Model;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocument _document;
        public DocumentController(IDocument doc)
        {
            _document = doc;
        }
        [HttpGet("get-all-document")]
        public ActionResult<IEnumerable<Document>> GetUsers()
        {
            var cls = _document.GetAllDocument();
            return Ok(cls);
        }
        [HttpPost("add-document")]
        public IActionResult AddClass(DocumentRequest request)
        {
            var add = _document.AddDocument(request);
            if (add == 0)
            {
                return BadRequest(new { message = "ten lop da ton tai" });
            }
            return Ok(new { message = "tao lop thanh cong" });
        }
        
        [HttpDelete("delete-document")]
        public IActionResult DeleteClass(int id)
        {
            int login = _document.DeleteDocument(id);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "xoa thanh cong" });
        }
        [HttpPost("update-document")]
        public IActionResult UpdateClass(int id, DocumentRequest rq)
        {
            int login = _document.UpdateDocument(id, rq);
            if (login == 0)
            {
                return BadRequest(new { message = "khong tim thay lop" });
            }
            return Ok(new { message = "thay doi thanh cong" });
        }
    }
}

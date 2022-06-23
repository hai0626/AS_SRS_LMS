using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Request
{
    public class DocumentRequest
    {
        [Required(ErrorMessage = "Please enter at least 10 numbers!!!")]
        public string DocumentName { get; set; } = string.Empty;

        [Required]
        public string link { get; set; }

        [Required]
        public int SubjectId { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Request
{
    public class SubjectRequest
    {
        [Required(ErrorMessage = "Please enter at least 10 numbers!!!")]
        public string SubjectName { get; set; } = string.Empty;

        [Required]
        public int Period { get; set; }

        [Required]
        public DateTime StartDay { get; set; }

        [Required]
        public DateTime EndDay { get; set; } 

    }
}

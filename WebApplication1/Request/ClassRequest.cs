using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Request
{
    public class ClassRequest
    {
        [Required(ErrorMessage = "Please enter at least 10 numbers!!!")]
        public string Name { get; set; } = string.Empty;
        [Required, MinLength(10, ErrorMessage = "Please enter at least 10 numbers!!!")]
        public bool status { get; set; }
        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters!!!")]
        public int Amount { get; set; } 

    }
}

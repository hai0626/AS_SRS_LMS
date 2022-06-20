using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Request
{
    public class ClassRequest
    {
        [Required(ErrorMessage = "Please enter at least 10 numbers!!!")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string link { get; set; }

        [Required]
        public bool status { get; set; }

        [Required]
        public int Amount { get; set; } 

    }
}

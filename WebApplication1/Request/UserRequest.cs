using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Request
{
    public class UserRequest
    {

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(10, ErrorMessage = "Please enter at least 10 numbers!!!")]
        public string phone { get; set; }
        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters!!!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public int RoleId { get; set; }

    }
}

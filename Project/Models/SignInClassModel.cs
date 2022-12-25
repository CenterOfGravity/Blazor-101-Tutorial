using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class SignInClassModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

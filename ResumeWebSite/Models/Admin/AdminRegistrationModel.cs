using System.ComponentModel.DataAnnotations;

namespace ResumeWebSite.Models.Admin
{
    public class AdminRegistrationModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Your login must be at least 5 characters")]
        public string Login { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Your password must contains at least 6 characters")]
        public string Password { get; set; }
    }
}

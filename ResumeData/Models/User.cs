using System.ComponentModel.DataAnnotations;

namespace ResumeData.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "Your login must be at least 5 characters")]
        public string Login { get; set; }
        [Required]
        [StringLength(6, ErrorMessage = "Your password must contains at least 6 characters")]
        public string Password { get; set; }
        [Required]
        [StringLength(3, ErrorMessage = "Your UserName must be at least 3 characters")]
        public string UserName { get; set; }
        [Required]
        public byte Role { get; set; }
        public string Salt { get; set; }
    }
}

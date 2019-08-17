using System.ComponentModel.DataAnnotations;

namespace ResumeWebSite.Models.Admin
{
    public class AdminLoginModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

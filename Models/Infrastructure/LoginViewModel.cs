using System.ComponentModel.DataAnnotations;

namespace DriftNews.Models.Infrastructure
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Укажите Имя")]
        [MaxLength(20, ErrorMessage = "Имя должно иметь длину меньше 20 символов")]
        [MinLength(3, ErrorMessage = "Имя должно иметь длину более 3 символов")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен иметь длину более 6 символов")]
        public string Password { get; set; }
    }
}

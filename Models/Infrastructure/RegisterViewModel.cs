using System.ComponentModel.DataAnnotations;

namespace DriftNews.Models.Infrastructure
{
    public class RegisterViewModel
    { 

        [Required(ErrorMessage = "Укажите логин")]
        [MaxLength(20, ErrorMessage = "Логин должен иметь длину меньше 20 символов")]
        [MinLength(3, ErrorMessage = "Логин должен иметь длину более 3 символов")]
        public string Username { get; set; }  
    
        [Required(ErrorMessage = "Укажите Имя")]
        [MaxLength(20, ErrorMessage = "Имя должно иметь длину меньше 20 символов")]
        [MinLength(3, ErrorMessage = "Имя должно иметь длину более 3 символов")]
        public string Name { get;set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен иметь длину более 6 символов")]
        public string Password { get;set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get;set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Form_Application.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyisim Giriniz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Cünsiyet Seçiniz")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }
    }
}

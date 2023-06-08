using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Form_Application.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}

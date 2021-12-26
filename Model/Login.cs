using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminJwtToken.Model
{
    public class Login
    {
        [Required(ErrorMessage = "Kullanıcı Adı zorunlu")]
        [DisplayName("Kullanıcı Adı")]
        [StringLength(60)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre zorunlu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

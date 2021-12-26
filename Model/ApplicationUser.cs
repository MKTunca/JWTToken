using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminJwtToken.Model
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        [DisplayName("Ad Soyad")]
        [StringLength(60)]
        public string FullName { get; set; }

        
    }
}

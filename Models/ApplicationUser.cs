using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace loginAspNet.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public override string Email { get => base.Email; set => base.Email = value; }
    }
}

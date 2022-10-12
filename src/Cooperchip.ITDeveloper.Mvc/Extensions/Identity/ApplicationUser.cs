using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.Identity

{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(35, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Apelido { get; set; }

        [PersonalData]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [Display(Name = "Nome Completo")]
        [StringLength(80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string NomeCompleto { get; set; }

        [PersonalData]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [ProtectedPersonalData]
        [StringLength(maximumLength: 255, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 21)]
        [DataType(DataType.Text)]
        public string ImgProfilePath { get; set; }
    }
}

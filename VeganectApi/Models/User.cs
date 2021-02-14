using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeganectApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório!")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        [StringLength(50)]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(25, ErrorMessage = "A senha precisa conter entre 8 ou 25 caracteres", MinimumLength = 8)]
        public string Password { get; set; }

        [Display(Name = "Insira a senha novamente")]
        [Compare("Password", ErrorMessage = "Error: A senha digitada não corresponde a senha digitada anteriomente! ")]
        public string ConfirmPassword { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMaster.MVC.ViewsModel
{
    public class UsuarioViewModel
    {
        [Key]
        public int UsuarioId { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(150,ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatorio.")]
        [MaxLength(150, ErrorMessage = "No maximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "Informe um E-mail Valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatorio.")]
        [MaxLength(11, ErrorMessage = "No maximo de {0} caracteres.")]
        [Display(Name = "CPF")]
        public long Cpf { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatorio.")]
        [MaxLength(10, ErrorMessage = "No maximo de {0} caracteres.")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatorio.")]
        [MaxLength(10, ErrorMessage = "No maximo de {0} caracteres.")]
        [Display(Name = "Confirme Senha")]
        public string ConfirmeSenha { get; set; }
    }
}
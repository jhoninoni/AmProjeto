using ProjetoMaster.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjetoMaster.Domain.Entities
{
    public class PessoaModelView
    {
        #region Propriedades

        [HiddenInput(DisplayValue = false)]
        public int PessoaDomainId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(150, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(150, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(150, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        [Display(Name="Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(12, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(10, ErrorMessage = "No minimo de {0} caracteres.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(11, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(9, ErrorMessage = "No minimo de {0} caracteres.")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        public Sexo Sexo { get; set; }

        public EnderecoModelView Endereco { get; set; }

        #endregion
    }
}

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
    public class UsuarioModelView
    {
        #region Propriedaes

        [Key]
        public int UsuarioDomainId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(25, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(15, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(15, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        [DataType(DataType.Password)]
        public string ConfirmSenha { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Este campo é obrigatorio.")]
        [MaxLength(150, ErrorMessage = "No máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "No minimo de {0} caracteres.")]
        [DataType(DataType.Password)]
        public DateTime DataCriacao { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime DataUltimoAcesso { get; set; }

        public bool Ativo { get; set; }

        public bool Bloqueado { get; set; }

        public PessoaDomain Pessoa { get; set; }

        public PerfilUsuario Perfil { get; set; }

        #endregion
    }
}

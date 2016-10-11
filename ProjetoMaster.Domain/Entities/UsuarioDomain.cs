using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoMaster.Domain.Enum;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Usuario")]
    public class UsuarioDomain
    {
        #region Propriedaes

        public int UsuarioDomainId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimoAcesso { get; set; }
        public bool Ativo { get; set; }
        public bool Bloqueado { get; set; }
        public PessoaDomain Pessoa { get; set; }
        public int PessoaId { get; set; }
        public PerfilUsuario Perfil { get; set; }

        #endregion
    }
}

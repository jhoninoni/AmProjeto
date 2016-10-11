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
    [Table("Pessoa")]
    public class PessoaDomain
    {
        #region Propriedades

        public int PessoaDomainId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Sexo Sexo { get; set; }
        public EnderecoDomain Endereco { get; set; }
        public int EnderecoId { get; set; }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Funcionario")]
    public class FuncionarioDomain
    {
        #region Construtor

        public FuncionarioDomain()
        {
            DataLigamento = DateTime.Now;
        }
        
        #endregion

        #region Propriedades

        public int FuncionarioDomainId { get; set; }
        public CargoDomain Cargo { get; set; }
        public int CargoId { get; set; }
        public DateTime DataLigamento { get; set; }
        public DateTime DataDesligamento { get; set; }
        public PessoaDomain Pessoa { get; set; }
        public int PessoaId { get; set; } 
        #endregion
    }
}

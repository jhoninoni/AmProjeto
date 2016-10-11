using ProjetoMaster.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Atividade")]
    public class AtividadeDomain
    {
        #region Construtor

        public AtividadeDomain()
        {
            DataCadastro = DateTime.Now;
        }

        #endregion

        #region Propriedades

        public int AtividadeDomainId { get; set; }
        public AlunoDomain Aluno { get; set; }
        public int AlunoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public TipoAtividade Tipoatividade { get; set; }

        #endregion
    }
}

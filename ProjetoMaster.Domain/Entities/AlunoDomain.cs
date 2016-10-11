using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Aluno")]
    public class AlunoDomain
    {
        #region Propriedade

        public int AlunoDomainId { get; set; }
        public EvacuacaoDomain Evacuacao { get; set; }
        public int EvacuacaoId { get; set; }
        public AlimentacaoDomain Alimentacao { get; set; }
        public int AlimentacaoId { get; set; }
        public SonoDomain Sono { get; set; }
        public int SonoId { get; set; }
        public BanhoDomain Banho { get; set; }
        public int BanhoId { get; set; }
        public SerieDomain Serie { get; set; }
        public int SerieId { get; set; }
        public PessoaDomain Pessoa { get; set; }
        public int PessoaId { get; set; }

        #endregion
    }
}

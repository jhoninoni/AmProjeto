using ProjetoMaster.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Alimentacao")]
    public class AlimentacaoDomain
    {
        #region Construtor

        public AlimentacaoDomain()
        {
            DataRefeicao = DateTime.Now;
        }

        #endregion

        #region Propriedades

        public int AlimentacaoDomainId { get; set; }
        public TipoRefeicao TipoRefeicao { get; set; }
        public StatusRefeicao StatusRefeicao { get; set; }
        public DateTime DataRefeicao { get; set; }
     
        #endregion
    }
}

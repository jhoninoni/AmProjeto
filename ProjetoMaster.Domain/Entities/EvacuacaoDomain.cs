using ProjetoMaster.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Evacuacao")]
    public class EvacuacaoDomain
    {
        #region Construtor

        public EvacuacaoDomain()
        {

        }

        #endregion

        #region Propriedades

        public int EvacuacaoDomainId { get; set; }
        public string DescEvacuacao { get; set; }
        public Periodo Periodo { get; set; }

        public TipoEvacuacao TipoEvacuacao { get; set; }
        #endregion
    }
}

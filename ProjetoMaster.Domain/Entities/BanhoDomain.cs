using ProjetoMaster.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Banho")]
    public class BanhoDomain
    {
        #region Construtor

        public BanhoDomain()
        {

        }

        #endregion

        #region Propriedades

        public int BanhoDomainId { get; set; }
        public string DescrBanho { get; set; }
        public TipoBanho TipoBanho { get; set; }

        #endregion
    }
}

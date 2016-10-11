using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Cargo")]
    public class CargoDomain
    {
        #region Construtor

        public CargoDomain()
        {

        }

        #endregion

        #region Propriedades

        public int CargoDomainId { get; set; }
        public string Nome { get; set; }

        #endregion
    }
}

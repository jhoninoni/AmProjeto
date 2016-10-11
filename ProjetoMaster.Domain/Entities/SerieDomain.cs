using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Serie")]
    public class SerieDomain
    {
        #region Construtor

        public SerieDomain()
        {

        }
   
        #endregion

        #region Propriedades

        public int SerieDomainId { get; set; }
        public string NomeSerie { get; set; }
        public int IdadeInicial { get; set; }
        public int IdadeFinal { get; set; }

        #endregion
    }
}

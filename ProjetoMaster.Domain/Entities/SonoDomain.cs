using ProjetoMaster.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Sono")]
    public class SonoDomain
    {
        #region Construtor

        public SonoDomain()
        {
            DataInicialSono = DateTime.Now;
        }

        #endregion

        #region Propriedades

        public int SonoDomainId { get; set; }
        public TipoSono TipoSono { get; set; }
        public DateTime DataInicialSono { get; set; }
        public DateTime DataFinalSono { get; set; }

        #endregion
    }
}

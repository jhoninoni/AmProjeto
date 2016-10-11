using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Estado")]
    public class EstadoDomain
    {
        #region Construtores
        public EstadoDomain()
        {
            ListaCidades = new List<CidadeDomain>();
        }

        #endregion

        #region Propriedades

        public int EstadoDomainId { get; set; }

        public string Nome { get; set; }

        public int CodPostal { get; set; }

        public List<CidadeDomain> ListaCidades { get; set; }

        #endregion
    }
}

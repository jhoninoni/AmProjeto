using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Cidade")]
    public class CidadeDomain
    {
        #region Contrutores
        public CidadeDomain()
        {
            ListaBairros = new List<BairroDomain>();
        }

        #endregion

        #region Propriedade

        public int CidadeDomainId { get; set; }
        public string Nome { get; set; }
        public EstadoDomain Estado { get; set; }
        public int EstadoId { get; set; }
        public List<BairroDomain> ListaBairros { get; set; }

        #endregion
    }
}

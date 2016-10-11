using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    public class CidadeModelView
    {
        #region Propriedade

        public int CidadeDomainId { get; set; }

        public string Nome { get; set; }

        public List<BairroModelView> Bairro { get; set; }

        #endregion
    }
}

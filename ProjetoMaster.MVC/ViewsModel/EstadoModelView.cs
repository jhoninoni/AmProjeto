using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    public class EstadoModelView
    {
        #region Propriedades

        public int EstadoDomainId { get; set; }

        public string Nome { get; set; }

        public List<CidadeModelView> Cidades { get; set; }

        #endregion
    }
}

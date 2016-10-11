using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    public class EnderecoModelView
    {
        #region Propriedades

        public int EnderecoDomainId { get; set; }

        public string Logradouro {get;set;}

        public string Numero { get; set; }

        public string Observacao { get; set; }

        public int Cep { get; set; }

        public List<EstadoModelView> Estados { get; set; }
        
        #endregion
    }
}

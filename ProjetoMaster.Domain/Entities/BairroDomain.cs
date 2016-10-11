using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Bairro")]
    public class BairroDomain
    {
        #region Propriedades

        public int BairroDomainId { get; set; }
        public string Nome { get; set; }
        public CidadeDomain Cidade { get;set;}
        public int CidadeId { get; set; }

        #endregion
    }
}

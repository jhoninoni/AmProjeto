using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Endereco")]
    public class EnderecoDomain
    {
        #region Propriedades

        public int EnderecoDomainId { get; set; }
        public string Logradouro {get;set;}
        public string Numero { get; set; }
        public string Observacao { get; set; }
        public int Cep { get; set; }
        public EstadoDomain Estado { get; set; }
        public int EstadoId { get; set; }
        public CidadeDomain Cidade { get; set; }
        public int CidadeId { get; set; }
        public BairroDomain Bairro { get; set; }
        public int BairroId { get; set; }

        #endregion
    }
}

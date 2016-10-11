using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("DadosSensor")]
    public class DadosSensorDomain
    {
        #region Construtor

        public DadosSensorDomain()
        {
            DataCadastro = DateTime.Now;
        }

        #endregion

        #region Propriedades

        public int DadosSensorDomainId { get; set; }
        public bool Chegada { get; set; }
        public int Batimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public SensorDomain SensorDomain { get; set; }
        public int SensorId { get; set; }
        public PessoaDomain PessoaDomain { get; set; }
        public int PessoaId { get; set; }

        #endregion
    }
}

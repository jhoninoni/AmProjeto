using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Sensor")]
    public class SensorDomain
    {
        #region Construtor

        public SensorDomain()
        {

        }
        
        #endregion

        #region Propriedades

        public int SensorDomainId { get; set; }

        public int CodigoFabrica { get; set; }

        public string NomeSensor { get; set; }
        
        #endregion
    }
}

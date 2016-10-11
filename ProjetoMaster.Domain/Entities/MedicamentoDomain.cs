using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Domain.Entities
{
    [Table("Medicamento")]
    public class MedicamentoDomain
    {
        #region Construtor

        public MedicamentoDomain()
        {
            DataMedicado = DateTime.Now;
        }

        #endregion

        #region Propriedade

        public int MedicamentoDomainId { get; set; }
        public string Nome { get; set; }
        public int QtdDose { get; set; }
        public DateTime DataMedicado { get; set; }
        public FuncionarioDomain Funcionario { get; set; }
        public int FuncionarioId { get; set; }

        #endregion
    }
}

using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class MedicamentoConfiguration : EntityTypeConfiguration<MedicamentoDomain>
    {
        public MedicamentoConfiguration()
        {
            Property(x => x.Nome).IsRequired();
            Property(x => x.QtdDose).IsRequired();
            Property(x => x.DataMedicado).IsRequired();
            HasRequired(x => x.Funcionario).WithMany().HasForeignKey(x => x.FuncionarioId);
        }
    }
}

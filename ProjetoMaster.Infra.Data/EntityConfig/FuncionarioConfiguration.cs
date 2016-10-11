using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<FuncionarioDomain>
    {
        public FuncionarioConfiguration()
        {
            HasRequired(x => x.Cargo).WithMany().HasForeignKey(x => x.CargoId);
            HasRequired(x => x.Pessoa).WithMany().HasForeignKey(x => x.PessoaId);
            Property(x => x.DataLigamento).IsRequired();
            Property(x => x.DataDesligamento).IsOptional();
        }
    }
}

using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class AtividadeConfiguration : EntityTypeConfiguration<AtividadeDomain>
    {
        public AtividadeConfiguration()
        {
            Property(x => x.DataCadastro).IsRequired();
            HasRequired(x => x.Aluno).WithMany().HasForeignKey(x => x.AlunoId);
        }
    }
}

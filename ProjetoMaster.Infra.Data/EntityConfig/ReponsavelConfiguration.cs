using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class ReponsavelConfiguration : EntityTypeConfiguration<ResponsavelAlunoDomain>
    {
        public ReponsavelConfiguration()
        {
            HasRequired(x => x.Pessoa).WithMany().HasForeignKey(x => x.PessoaId);
            HasRequired(x => x.Aluno).WithMany().HasForeignKey(x => x.AlunoId);
        }
    }
}

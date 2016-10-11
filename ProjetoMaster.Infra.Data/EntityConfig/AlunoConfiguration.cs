using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class AlunoConfiguration : EntityTypeConfiguration<AlunoDomain>
    {
        public AlunoConfiguration()
        {
            HasRequired(x => x.Alimentacao).WithMany().HasForeignKey(x => x.AlimentacaoId);
            HasRequired(x => x.Evacuacao).WithMany().HasForeignKey(x => x.EvacuacaoId);
            HasRequired(x => x.Sono).WithMany().HasForeignKey(x => x.SonoId);
            HasRequired(x => x.Banho).WithMany().HasForeignKey(x => x.BanhoId);
            HasRequired(x => x.Serie).WithMany().HasForeignKey(x => x.SerieId);
            HasRequired(x => x.Pessoa).WithMany().HasForeignKey(x => x.PessoaId);
        }
    }
}

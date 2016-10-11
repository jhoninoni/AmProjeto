using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class CidadeConfiguration : EntityTypeConfiguration<CidadeDomain>
    {
        public CidadeConfiguration()
        {
            HasKey(x => x.CidadeDomainId);
            Property(x => x.Nome).IsRequired();
            HasMany(x => x.ListaBairros).WithRequired(x => x.Cidade).HasForeignKey(x => x.CidadeId);
            HasRequired(x => x.Estado).WithMany().HasForeignKey(x => x.EstadoId);
        }
    }
}

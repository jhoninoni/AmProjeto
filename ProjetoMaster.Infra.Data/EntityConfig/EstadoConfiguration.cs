using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class EstadoConfiguration :EntityTypeConfiguration<EstadoDomain>
    {
        public EstadoConfiguration()
        {
            HasKey(x => x.EstadoDomainId);
            Property(x => x.Nome).IsRequired();
            HasMany(x => x.ListaCidades).WithRequired(x => x.Estado).HasForeignKey(x => x.EstadoId);
        }
    }
}

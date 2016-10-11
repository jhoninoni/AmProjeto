using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class BairroConfiguration : EntityTypeConfiguration<BairroDomain>
    {
        public BairroConfiguration()
        {
            HasKey(x => x.BairroDomainId).HasEntitySetName("Id");
            Property(x => x.Nome).IsRequired();
            HasRequired(x => x.Cidade).WithMany().HasForeignKey(x => x.CidadeId);
        }
    }
}

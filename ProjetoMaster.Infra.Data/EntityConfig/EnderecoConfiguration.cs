using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration :EntityTypeConfiguration<EnderecoDomain>
    {
        public EnderecoConfiguration()
        {
            HasKey(x => x.EnderecoDomainId);
            Property(x => x.Logradouro).IsRequired();
            Property(x => x.Numero).IsRequired().HasMaxLength(5);
            Property(x => x.Observacao).IsRequired();
            Property(x => x.Cep).IsRequired().HasColumnType("int");
            HasRequired(x => x.Estado).WithMany().HasForeignKey(x => x.EstadoId);
            HasRequired(x => x.Cidade).WithMany().HasForeignKey(x => x.CidadeId);
            HasRequired(x => x.Bairro).WithMany().HasForeignKey(x => x.BairroId);
        }
    }
}

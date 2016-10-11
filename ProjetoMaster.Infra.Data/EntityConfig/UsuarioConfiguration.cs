using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaster.Domain.Entities;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<UsuarioDomain>
    {
        public UsuarioConfiguration()
        {
            HasKey(x => x.UsuarioDomainId);
            Property(x => x.Login).IsRequired();
            Property(x => x.Senha).IsRequired();
            Property(x => x.DataCriacao).IsRequired();
            Property(x => x.DataUltimoAcesso).IsRequired();
            Property(x => x.Ativo).IsRequired();
            Property(x => x.Bloqueado).IsRequired();
            Property(x => x.Perfil).IsRequired().HasColumnType("int");
            HasRequired(x => x.Pessoa).WithMany().HasForeignKey(x => x.PessoaId);
        }
    }
}

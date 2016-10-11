using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class PessoaConfiguration : EntityTypeConfiguration<PessoaDomain>
    {
        public PessoaConfiguration()
        {
            HasKey(x => x.PessoaDomainId);
            Property(x => x.Nome).IsRequired().HasColumnName("Nome");
            Property(x => x.SobreNome).IsRequired().HasColumnName("SobreNome");
            Property(x => x.DataNascimento).IsRequired().HasColumnName("DataNascimento");
            Property(x => x.CPF).IsRequired().HasMaxLength(15).HasColumnName("CPF");
            Property(x => x.RG).IsRequired().HasMaxLength(15).HasColumnName("RG");
            Property(x => x.Sexo).IsRequired().HasColumnName("Sexo");
            HasRequired(x => x.Endereco).WithMany().HasForeignKey(t => t.EnderecoId);
        }
    }
}

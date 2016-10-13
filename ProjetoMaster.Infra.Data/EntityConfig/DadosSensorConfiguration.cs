using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class DadosSensorConfiguration : EntityTypeConfiguration<DadosSensorDomain>
    {
        public DadosSensorConfiguration()
        {
            Property(x => x.Batimento).IsRequired();
            Property(x => x.Chegada).IsRequired();
            Property(x => x.DataCadastro).IsRequired();
            Property(x => x.CodSensor).IsRequired();
            HasRequired(x => x.PessoaDomain).WithMany().HasForeignKey(x => x.PessoaId);
            HasRequired(x => x.SensorDomain).WithMany().HasForeignKey(x => x.SensorId);
            HasRequired(x => x.Aluno).WithMany().HasForeignKey(x => x.AlunoId);
        }
    }
}

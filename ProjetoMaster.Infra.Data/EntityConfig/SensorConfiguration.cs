using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.EntityConfig
{
    public class SensorConfiguration : EntityTypeConfiguration<SensorDomain>
    {
        public SensorConfiguration()
        {
            HasKey(x => x.SensorDomainId);
            Property(x => x.NomeSensor).IsRequired().HasColumnName("Nome");
            Property(x => x.CodigoFabrica).IsRequired().HasColumnType("int").HasColumnName("Codigo");
        }
    }
}

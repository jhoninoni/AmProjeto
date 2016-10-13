using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.EntityConfig;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoMaster.Domain.Enum;

namespace ProjetoMaster.Infra.Data.Contexto
{
    public class ContextDb : DbContext
    {
        public ContextDb()
            : base("BabyCare")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<BairroDomain> Bairros { get; set; }
        public DbSet<CidadeDomain> Cidades { get; set; }
        public DbSet<DadosSensorDomain> DadosSensores { get; set; }
        public DbSet<EnderecoDomain> Enderecos { get; set; }
        public DbSet<EstadoDomain> Estados { get; set; }
        public DbSet<PessoaDomain> Pessoas { get; set; }
        public DbSet<SensorDomain> Sensores { get; set; }
        public DbSet<UsuarioDomain> Usuarios { get; set; }
        public DbSet<AlimentacaoDomain> Alimentacaos { get; set; }
        public DbSet<AlunoDomain> Alunos { get; set; }
        public DbSet<CargoDomain> Cargos { get; set; }
        public DbSet<EvacuacaoDomain> Evacuacaos { get; set; }
        public DbSet<FuncionarioDomain> Funcionarios { get; set; }
        public DbSet<MedicamentoDomain> Medicamentos { get; set; }
        public DbSet<SerieDomain> Series { get; set; }
        public DbSet<SonoDomain> Sonos { get; set; }
        public DbSet<AtividadeDomain> Atividades { get; set; }
        public DbSet<ResponsavelAlunoDomain> Responsavels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(150));
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.HasColumnName("Id"));

            modelBuilder.Configurations.Add(new BairroConfiguration());
            modelBuilder.Configurations.Add(new CidadeConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new SensorConfiguration());
            modelBuilder.Configurations.Add(new DadosSensorConfiguration());
            modelBuilder.Configurations.Add(new AlunoConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new MedicamentoConfiguration());
            modelBuilder.Configurations.Add(new AtividadeConfiguration());
            modelBuilder.Configurations.Add(new ReponsavelConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

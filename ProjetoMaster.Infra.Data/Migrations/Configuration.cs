namespace ProjetoMaster.Infra.Data.Migrations
{
    using ProjetoMaster.Domain.Entities;
    using ProjetoMaster.Domain.Enum;
    using ProjetoMaster.Infra.Data.Contexto;
    using ProjetoMaster.Infra.Data.MassaDados;
    using ProjetoMaster.Infra.Data.Repositories;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContextDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ContextDb context)
        {
            new EstadoDados();
            new CidadeDados();
            new BairroDados();
            new EnderecoDados();
            new AlimentacaoDados();
            new BanhoDados();
            new CargoDados();
            new SensorDados();
            new SerieDados();
            new SonoDados();
            new EvacuacaoDados();
            new PessoaDados();
            new AlunoDados();
            new FuncionarioDados();
            new MedicamentoDados();
            new UsuarioDados();
            new DadosSensorDados();
            new AtividadeDados();
            //new ResponsavelDados();
        }
    }
}

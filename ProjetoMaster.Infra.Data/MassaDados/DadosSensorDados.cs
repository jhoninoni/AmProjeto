using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Domain.Enum;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class DadosSensorDados
    {
        public DadosSensorDados()
        {
            var repositoryDadosSensor = new DadosSensorRepository();
            var repositoryPessoa = new PessoaRepository().GetAll().FirstOrDefault();
            var repositorySensor = new SensorRepository().GetAll().ToList();

            try
            {
                repositoryDadosSensor.Add(new DadosSensorDomain()
                {
                    CodSensor = 22940168107,
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    SensorId = repositorySensor.Find(x => x.SensorDomainId == 1).SensorDomainId,
                    DataCadastro = DateTime.Now,
                    AlunoId = 1,
                    Chegada = true,
                    Batimento = 150,
                    Tipoatividade = TipoAtividade.EntradaEscola
                });

                repositoryDadosSensor.Add(new DadosSensorDomain()
                {
                    CodSensor = 22940168107,
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    SensorId = repositorySensor.Find(x => x.SensorDomainId == 1).SensorDomainId,
                    DataCadastro = DateTime.Now,
                    AlunoId = 1,
                    Chegada = true,
                    Batimento = 110,
                    Tipoatividade = TipoAtividade.CafeManha
                });

                repositoryDadosSensor.Add(new DadosSensorDomain()
                {
                    CodSensor = 22940168107,
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    SensorId = repositorySensor.Find(x => x.SensorDomainId == 1).SensorDomainId,
                    DataCadastro = DateTime.Now,
                    AlunoId = 1,
                    Chegada = true,
                    Batimento = 110,
                    Tipoatividade = TipoAtividade.Banheiro
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryDadosSensor.Dispose();
            }
        }
    }
}

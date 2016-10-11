using ProjetoMaster.Domain.Entities;
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
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    SensorId = repositorySensor.Find(x => x.SensorDomainId == 1).SensorDomainId,
                    DataCadastro = DateTime.Now,
                    Chegada = true,
                    Batimento = 150
                });

                repositoryDadosSensor.Add(new DadosSensorDomain()
                {
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    SensorId = repositorySensor.Find(x => x.SensorDomainId == 2).SensorDomainId,
                    DataCadastro = DateTime.Now,
                    Chegada = true,
                    Batimento = 110
                });

                repositoryDadosSensor.Add(new DadosSensorDomain()
                {
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    SensorId = repositorySensor.Find(x => x.SensorDomainId == 3).SensorDomainId,
                    DataCadastro = DateTime.Now,
                    Chegada = true,
                    Batimento = 120
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

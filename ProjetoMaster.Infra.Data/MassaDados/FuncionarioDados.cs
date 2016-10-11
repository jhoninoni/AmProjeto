using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class FuncionarioDados
    {
        public FuncionarioDados()
        {
            var repositoryFuncionario = new FuncionarioRepository();
            var repositoryPessoa = new PessoaRepository().GetAll().FirstOrDefault();
            var repositoryCargo = new CargoRepository().GetAll().FirstOrDefault();

            try
            {
                repositoryFuncionario.Add(new FuncionarioDomain()
                {
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    CargoId = repositoryCargo.CargoDomainId,
                    DataLigamento = DateTime.Now.AddYears(-1),
                    DataDesligamento = DateTime.Now
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                repositoryFuncionario.Dispose();
            }
        }
    }
}

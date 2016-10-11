using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class EnderecoDados
    {
        public EnderecoDados()
        {
            var repositoryEndereco = new EnderecoRepository();
            var repositoryEstado = new EstadoRepository().GetAll().FirstOrDefault();
            var repositoryCidade = new CidadeRepository().GetAll().FirstOrDefault();
            var repositoryBairro = new BairroRepository().GetAll().FirstOrDefault();

            try
            {
                repositoryEndereco.Add(new EnderecoDomain()
                {
                    Cep = 07141380,
                    Logradouro = "Rua iepê",
                    Numero = "118",
                    Observacao = "Prox Praça 8",
                    EstadoId = repositoryEstado.EstadoDomainId,
                    CidadeId = repositoryCidade.CidadeDomainId,
                    BairroId = repositoryBairro.BairroDomainId
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryEndereco.Dispose();
            }
        }
    }
}

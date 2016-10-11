using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class BairroDados
    {
        public BairroDados()
        {
            var repositoryBairro = new BairroRepository();
            var repositoryCidade = new CidadeRepository().GetAll().ToList().Find(x => x.Nome == "Guarulhos");

            try
            {
                repositoryBairro.Add(new BairroDomain()
                {
                    Nome = "Jd Silvia",
                    CidadeId = repositoryCidade.CidadeDomainId
                });

                repositoryBairro.Add(new BairroDomain()
                {
                    Nome = "Vl Galvão",
                    CidadeId = repositoryCidade.CidadeDomainId
                });

                repositoryBairro.Add(new BairroDomain()
                {
                    Nome = "Bosque Maia",
                    CidadeId = repositoryCidade.CidadeDomainId
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryBairro.Dispose();
            }
        }
    }
}

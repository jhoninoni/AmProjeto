using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class CidadeDados
    {
        public CidadeDados()
        {
            var repositoryCidade = new CidadeRepository();
            var repositoryEstado = new EstadoRepository().GetAll().ToList();

            try
            {

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Guarulhos",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 11).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Barueri",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 11).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Osasco",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 11).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "São Paulo",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 11).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Rio de Janeiro",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 21).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Macaé",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 21).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Volta Redonda",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 21).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Londrina",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 43).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Maringá",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 43).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Curitiba",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 43).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Salvador",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 40).EstadoDomainId
                });

                repositoryCidade.Add(new CidadeDomain()
                {
                    Nome = "Vitoria da Conquista",
                    EstadoId = repositoryEstado.Find(x => x.CodPostal == 40).EstadoDomainId
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryCidade.Dispose();
            }
        }
    }
}

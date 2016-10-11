using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class EstadoDados
    {
        public EstadoDados()
        {
            var repositoryEstado = new EstadoRepository();

            try
            {

                repositoryEstado.Add(new EstadoDomain()
                {
                    Nome = "São Paulo",
                    CodPostal = 11
                });

                repositoryEstado.Add(new EstadoDomain()
                {
                    Nome = "Paraná",
                    CodPostal = 43
                });

                repositoryEstado.Add(new EstadoDomain()
                {
                    Nome = "Bahia",
                    CodPostal = 40
                });

                repositoryEstado.Add(new EstadoDomain()
                {
                    Nome = "Rio de Janeiro",
                    CodPostal = 21
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryEstado.Dispose();
            }
        }
    }
}

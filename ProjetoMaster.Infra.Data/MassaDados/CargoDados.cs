using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class CargoDados
    {
        public CargoDados()
        {
            var repositoryCargo = new CargoRepository();

            try
            {
                repositoryCargo.Add(new CargoDomain()
                {
                    Nome = "TI"
                });

                repositoryCargo.Add(new CargoDomain()
                {
                    Nome = "Porteiro"
                });

                repositoryCargo.Add(new CargoDomain()
                {
                    Nome = "Cozinheira"
                });

                repositoryCargo.Add(new CargoDomain()
                {
                    Nome = "Professora"
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryCargo.Dispose();
            }
        }
    }
}

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
    public class BanhoDados
    {
        public BanhoDados()
        {
            var repositoryBanho = new BanhoRepository();

            try
            {
                repositoryBanho.Add(new BanhoDomain()
                {
                    DescrBanho = "Quente-Morno",
                    TipoBanho = TipoBanho.Quente
                });

                repositoryBanho.Add(new BanhoDomain()
                {
                    DescrBanho = "Morno-Frio",
                    TipoBanho = TipoBanho.Morno
                });

                repositoryBanho.Add(new BanhoDomain()
                {
                    DescrBanho = "Frio-Morno",
                    TipoBanho = TipoBanho.Frio
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryBanho.Dispose();
            }
        }
    }
}

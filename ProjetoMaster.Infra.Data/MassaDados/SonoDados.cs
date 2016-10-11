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
    public class SonoDados
    {
        public SonoDados()
        {
            var repositorySono = new SonoRepository();

            try
            {
                repositorySono.Add(new SonoDomain()
                {
                    TipoSono = TipoSono.Leve,
                    DataInicialSono = DateTime.Now.AddHours(-3),
                    DataFinalSono = DateTime.Now
                });

                repositorySono.Add(new SonoDomain()
                {
                    TipoSono = TipoSono.Normal,
                    DataInicialSono = DateTime.Now.AddDays(-5).AddHours(-3),
                    DataFinalSono = DateTime.Now.AddDays(-5)
                });

                repositorySono.Add(new SonoDomain()
                {
                    TipoSono = TipoSono.Pesado,
                    DataInicialSono = DateTime.Now.AddDays(-7).AddHours(-3),
                    DataFinalSono = DateTime.Now.AddDays(-7)
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositorySono.Dispose();
            }
        }
    }
}

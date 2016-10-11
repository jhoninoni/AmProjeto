using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class SerieDados
    {
        public SerieDados()
        {
            var repositorySerie = new SerieRepository();

            try
            {
                repositorySerie.Add(new SerieDomain()
                {
                    NomeSerie = "Berçário 1",
                    IdadeInicial = 0,
                    IdadeFinal = 1
                });
                repositorySerie.Add(new SerieDomain()
                {
                    NomeSerie = "Berçário 2",
                    IdadeInicial = 1,
                    IdadeFinal = 2
                });
                repositorySerie.Add(new SerieDomain()
                {
                    NomeSerie = "Maternal 1",
                    IdadeInicial = 2,
                    IdadeFinal = 3
                });
                repositorySerie.Add(new SerieDomain()
                {
                    NomeSerie = "Maternal 2",
                    IdadeInicial = 3,
                    IdadeFinal = 4
                });
                repositorySerie.Add(new SerieDomain()
                {
                    NomeSerie = "Pré 1",
                    IdadeInicial = 4,
                    IdadeFinal = 5
                });
                repositorySerie.Add(new SerieDomain()
                {
                    NomeSerie = "Pré 1",
                    IdadeInicial = 5,
                    IdadeFinal = 6
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositorySerie.Dispose();
            }
        }
    }
}

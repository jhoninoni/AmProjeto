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
    public class EvacuacaoDados
    {
        public EvacuacaoDados()
        {
            var repositoryEvacuacao = new EvacuacaoRepository();

            try
            {
                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                   DescEvacuacao = "Diarreia Grave",
                   Periodo = Periodo.Manha,
                   TipoEvacuacao = TipoEvacuacao.Diarreia
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Diarreia Grave",
                    Periodo = Periodo.Tarde,
                    TipoEvacuacao = TipoEvacuacao.Diarreia
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Diarreia Grave",
                    Periodo = Periodo.Noite,
                    TipoEvacuacao = TipoEvacuacao.Diarreia
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Dificil Evacuação",
                    Periodo = Periodo.Manha,
                    TipoEvacuacao = TipoEvacuacao.Duro
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Dificil Evacuação",
                    Periodo = Periodo.Tarde,
                    TipoEvacuacao = TipoEvacuacao.Duro
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Dificil Evacuação",
                    Periodo = Periodo.Noite,
                    TipoEvacuacao = TipoEvacuacao.Duro
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Media Evacuação",
                    Periodo = Periodo.Manha,
                    TipoEvacuacao = TipoEvacuacao.Mole
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Media Evacuação",
                    Periodo = Periodo.Tarde,
                    TipoEvacuacao = TipoEvacuacao.Mole
                });

                repositoryEvacuacao.Add(new EvacuacaoDomain()
                {
                    DescEvacuacao = "Media Evacuação",
                    Periodo = Periodo.Noite,
                    TipoEvacuacao = TipoEvacuacao.Mole
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryEvacuacao.Dispose();
            }
        }
    }
}

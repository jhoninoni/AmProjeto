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
    public class AlimentacaoDados
    {
        public AlimentacaoDados()
        {
            var repositoryAlimentacao = new AlimentacaoRepository();

            try
            {
                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.Completo,
                    TipoRefeicao = TipoRefeicao.Cafe
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.Incompleto,
                    TipoRefeicao = TipoRefeicao.Cafe
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.NaoComeu,
                    TipoRefeicao = TipoRefeicao.Cafe
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.Completo,
                    TipoRefeicao = TipoRefeicao.Almoco
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.Incompleto,
                    TipoRefeicao = TipoRefeicao.Almoco
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.NaoComeu,
                    TipoRefeicao = TipoRefeicao.Almoco
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.Completo,
                    TipoRefeicao = TipoRefeicao.Janta
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.Incompleto,
                    TipoRefeicao = TipoRefeicao.Janta
                });

                repositoryAlimentacao.Add(new AlimentacaoDomain()
                {
                    DataRefeicao = DateTime.Now,
                    StatusRefeicao = StatusRefeicao.NaoComeu,
                    TipoRefeicao = TipoRefeicao.Janta
                });

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryAlimentacao.Dispose();
            }
        }
    }
}

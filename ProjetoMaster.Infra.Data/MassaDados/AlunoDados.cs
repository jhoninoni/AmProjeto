using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class AlunoDados
    {
        public AlunoDados()
        {
            var repositoryAluno = new AlunoRepository();
            var repositoryAlimentacao = new AlimentacaoRepository().GetAll().FirstOrDefault();
            var repositoryBanho = new BanhoRepository().GetAll().FirstOrDefault();
            var repositoryPessoa = new PessoaRepository().GetAll().FirstOrDefault();
            var repositorySerie = new SerieRepository().GetAll().FirstOrDefault();
            var repositorySono = new SonoRepository().GetAll().FirstOrDefault();
            var repositoryEvacuacao = new EvacuacaoRepository().GetAll().FirstOrDefault();

            try
            {
                repositoryAluno.Add(new AlunoDomain()
                {
                    AlimentacaoId = repositoryAlimentacao.AlimentacaoDomainId,
                    BanhoId = repositoryBanho.BanhoDomainId,
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    SerieId = repositorySerie.SerieDomainId,
                    SonoId = repositorySono.SonoDomainId,
                    EvacuacaoId = repositoryEvacuacao.EvacuacaoDomainId
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryAluno.Dispose();
            }
        }
    }
}

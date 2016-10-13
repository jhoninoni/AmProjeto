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
    public class AtividadeDados
    {
        public AtividadeDados()
        {
            var reprepositoryAtividade = new AtividadeRepository();
            var repositoryAluno = new AlunoRepository().GetAll().ToList();

            try
            {
                reprepositoryAtividade.Add(new AtividadeDomain()
                {
                    AlunoId = repositoryAluno[0].AlunoDomainId,
                    Tipoatividade = TipoAtividade.EntradaEscola
                });

                reprepositoryAtividade.Add(new AtividadeDomain()
                {
                    AlunoId = repositoryAluno[0].AlunoDomainId,
                    Tipoatividade = TipoAtividade.CafeManha
                });

                reprepositoryAtividade.Add(new AtividadeDomain()
                {
                    AlunoId = repositoryAluno[0].AlunoDomainId,
                    Tipoatividade = TipoAtividade.Banheiro
                });

                reprepositoryAtividade.Add(new AtividadeDomain()
                {
                    AlunoId = repositoryAluno[0].AlunoDomainId,
                    Tipoatividade = TipoAtividade.Almoco
                });
                reprepositoryAtividade.Add(new AtividadeDomain()
                {
                    AlunoId = repositoryAluno[0].AlunoDomainId,
                    Tipoatividade = TipoAtividade.Natacao
                });

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                reprepositoryAtividade.Dispose();
            }
        }
    }
}

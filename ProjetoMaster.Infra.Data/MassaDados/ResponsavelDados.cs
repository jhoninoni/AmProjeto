using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class ResponsavelDados
    {
        public ResponsavelDados()
        {
            var repositoryResponsavel = new ResponsavelRespository();

            try
            {
                repositoryResponsavel.Add(new ResponsavelAlunoDomain()
                {
                    AlunoId = 1,
                    PessoaId = 1,
                });

                repositoryResponsavel.Add(new ResponsavelAlunoDomain()
                {
                    AlunoId = 2,
                    PessoaId = 1,
                });
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                repositoryResponsavel.Dispose();
            }
        }
    }
}

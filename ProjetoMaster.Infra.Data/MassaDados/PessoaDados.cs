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
    public class PessoaDados
    {
        public PessoaDados()
        {
            var repositoryPessoa = new PessoaRepository();

            try
            {
                repositoryPessoa.Add(new PessoaDomain()
                {
                    Nome = "Jhoni",
                    SobreNome = "Oliveira",
                    DataNascimento = DateTime.Now.AddYears(-2),
                    CPF = "42053581808",
                    RG = "364407955",
                    Sexo = Sexo.Masculino,
                    EnderecoId = 1,
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                repositoryPessoa.Dispose();
            }
        }
    }
}

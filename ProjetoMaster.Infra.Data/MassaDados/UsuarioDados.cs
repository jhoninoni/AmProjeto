using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Domain.Enum;
using ProjetoMaster.Infra.CrossCuting.Criptografar;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Infra.Data.MassaDados
{
    public class UsuarioDados
    {
        public UsuarioDados()
        {
            var repositoryUsuario = new UsuarioRepository();
            var repositoryPessoa = new PessoaRepository().GetAll().FirstOrDefault();

            try
            {
                repositoryUsuario.Add(new UsuarioDomain()
                {
                    PessoaId = repositoryPessoa.PessoaDomainId,
                    Bloqueado = false,
                    Ativo = true,
                    DataCriacao = DateTime.Now.AddMinutes(-50),
                    DataUltimoAcesso = DateTime.Now,
                    Login= "Jhoni",
                    Perfil = PerfilUsuario.Administrador,
                    Senha = new Criptografia().Encrypt("123456")
                });
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                repositoryUsuario.Dispose();
            }
        }
    }
}

using Newtonsoft.Json;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.CrossCuting.Criptografar;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoMaster.Service.DadosPulseiraApi.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        #region Repositorio

        private readonly UsuarioRepository repositoryUsuario = new UsuarioRepository();

        #endregion

        #region Construtores
        public UsuarioController()
        {

        }

        #endregion

        #region Metodos

        [Route("get/listausuario")]
        [HttpGet]
        public IHttpActionResult ListaUsuario()
        {
            try
            {
                var listaUsuario = repositoryUsuario.GetAll().ToList();
                return Ok(listaUsuario);
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR");
            }

        }

        [Route("autenticacao/login")]
        [HttpPost]
        public IHttpActionResult Login(UsuarioDomain model)
        {
            try
            {
                var senha = new Criptografia().Encrypt(model.Senha.Trim()).ToUpper();
                var usuario = repositoryUsuario.GetAll().Where(n => n.Login.ToUpper().Equals(model.Login.Trim().ToUpper()) && n.Senha.ToUpper().Equals(senha.ToUpper())).ToList();

                return Ok((UsuarioDomain)usuario.FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR");
            }
        }

        // PUT api/Usuario
        public bool Put(UsuarioDomain model)
        {
            try
            {
                var senha = new Criptografia().Encrypt(model.Senha.Trim()).ToUpper();
                var usuario = repositoryUsuario.GetAll().Where(n => n.Login.ToUpper().Equals(model.Login.Trim().ToUpper()) && n.Senha.ToUpper().Equals(senha.ToUpper())).ToList();

                if (usuario.Count() == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}

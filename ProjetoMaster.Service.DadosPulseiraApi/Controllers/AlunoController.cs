using Newtonsoft.Json;
using ProjetoMaster.Application.Entities;
using ProjetoMaster.Application.Interfaces;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoMaster.Service.DadosPulseiraApi.Controllers
{
    [RoutePrefix("api/alunos")]
    public class AlunoController : ApiController
    {
        #region Repositorio

        private readonly AlunoRepository repositoryAluno = new AlunoRepository();

        #endregion

        #region Construtores
        public AlunoController()
        {

        }

        #endregion

        #region Metodos

        [Route("get/listaalunos")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var listaAluno = repositoryAluno.GetAll().ToList();
                return Ok(listaAluno);
            }
            catch (Exception)
            {
                return BadRequest("ERROR");
            }
        }

        public void Post(AlunoDomain model)
        {
            try
            {
                repositoryAluno.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Put(AlunoDomain model)
        {

        }

        [Route("get/aluno/{codigo}")]
        [HttpGet]
        public IHttpActionResult AlunoCodigo(int codigo)
        {
            try
            {
                var listaAluno = repositoryAluno.GetAll().Where(x => x.AlunoDomainId == codigo).FirstOrDefault();
                return Ok(listaAluno);
            }
            catch (Exception)
            {
                return BadRequest("ERROR");
            }
        }

        #endregion
    }
}

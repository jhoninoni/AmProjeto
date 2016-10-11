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

        // GET api/Aluno
        public string Get()
        {
            string jsonSerialize = "";

            try
            {
                var listaAluno = repositoryAluno.GetAll().ToList();
                jsonSerialize = JsonConvert.SerializeObject(listaAluno);
            }
            catch (Exception ex)
            {
                jsonSerialize = ex.Message;
            }

            return jsonSerialize;
        }

        // POST api/values
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

        // PUT api/values/5
        public void Put(AlunoDomain model)
        {

        }

        #endregion
    }
}

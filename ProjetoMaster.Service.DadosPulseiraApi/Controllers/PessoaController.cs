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
    public class PessoaController : ApiController
    {
        #region Repositorio

        private readonly PessoaRepository repositoryPessoa = new PessoaRepository();

        #endregion

        #region Construtores
        public PessoaController()
        {

        }

        #endregion

        #region Metodos

        // GET api/Pessoa
        public string Get()
        {
            string jsonSerialize = "";

            try
            {
                var listaPessoa = repositoryPessoa.GetAll().ToList();
                jsonSerialize = JsonConvert.SerializeObject(listaPessoa);
            }
            catch (Exception ex)
            {
                jsonSerialize = ex.Message;
            }

            return jsonSerialize;
        }

        // POST api/values
        public void Post(PessoaDomain model)
        {
            try
            {
                repositoryPessoa.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // PUT api/values/5
        public void Put(PessoaDomain model)
        {

        }

        #endregion
    }
}

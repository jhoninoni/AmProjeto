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
    public class AtividadeController : ApiController
    {
        #region Repositorio

        private readonly AtividadeRepository repository = new AtividadeRepository();

        #endregion

        #region Contrutor

        public AtividadeController()
        {

        }

        #endregion

        #region Metodos

        public string Get()
        {
            string jsonSerialize = "";

            try
            {
                var listaAtividades = repository.GetAll().ToList();
                jsonSerialize = JsonConvert.SerializeObject(listaAtividades);
            }
            catch (Exception ex)
            {
                jsonSerialize = ex.Message;
            }

            return jsonSerialize;
        }

        public void Post(AtividadeDomain model)
        {
            try
            {
                repository.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Put(AtividadeDomain model)
        {

        }

        #endregion
    }
}
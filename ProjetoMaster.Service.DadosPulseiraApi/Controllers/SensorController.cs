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
    public class SensorController : ApiController
    {
        #region Repositorio

        private readonly SensorRepository repositorySensor = new SensorRepository();

        #endregion

        #region Construtores
        public SensorController()
        {

        }

        #endregion

        #region Metodos

        // GET api/Sensor
        public string Get()
        {
            string jsonSerialize = "";

            try
            {
                var listaSensor = repositorySensor.GetAll().ToList();
                jsonSerialize = JsonConvert.SerializeObject(listaSensor);
            }
            catch (Exception ex)
            {
                jsonSerialize = ex.Message;
            }

            return jsonSerialize;
        }

        // POST api/values
        public void Post(SensorDomain model)
        {
            try
            {
                repositorySensor.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // PUT api/values/5
        public void Put(SensorDomain model)
        {

        }

        #endregion
    }
}

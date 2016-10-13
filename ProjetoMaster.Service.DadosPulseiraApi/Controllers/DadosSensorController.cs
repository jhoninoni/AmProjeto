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
    public class DadosSensorController : ApiController
    {
        #region Repositorio

        private readonly DadosSensorRepository repository = new DadosSensorRepository();
        private readonly PessoaRepository repositoryPessoa = new PessoaRepository();
        private readonly SensorRepository repositorySensor = new SensorRepository();
        private readonly EnderecoRepository repositoryEndereco = new EnderecoRepository();
        private readonly EstadoRepository repositoryEstado = new EstadoRepository();
        private readonly CidadeRepository repositoryCidade = new CidadeRepository();
        private readonly BairroRepository repositoryBairro = new BairroRepository();

        #endregion

        #region Contrutor

        public DadosSensorController()
        {

        }
        
        #endregion

        #region Metodos

        public string Get()
        {
            string jsonSerialize = "";

            try
            {
                var listaAcessoEscola = repository.GetAll().ToList();

                for (int i = 0; i < listaAcessoEscola.Count(); i++)
                {
                    var pessoa = repositoryPessoa.GetById(listaAcessoEscola[i].PessoaId);
                    var sensor = repositorySensor.GetById(listaAcessoEscola[i].SensorId);

                    var endereco = repositoryEndereco.GetById(pessoa.EnderecoId);
                    endereco.Estado = repositoryEstado.GetById(endereco.EstadoId);
                    endereco.Cidade = repositoryCidade.GetById(endereco.CidadeId);
                    endereco.Bairro = repositoryBairro.GetById(endereco.BairroId);

                    pessoa.Endereco = endereco;

                    listaAcessoEscola[i].PessoaDomain = pessoa;
                    listaAcessoEscola[i].SensorDomain = sensor;
                }

                jsonSerialize = JsonConvert.SerializeObject(listaAcessoEscola);
            }
            catch (Exception ex)
            {
                jsonSerialize = ex.Message;
            }

            return jsonSerialize;
        }

        public void Post(DadosSensorDomain model)
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

        public void Put(DadosSensorDomain model)
        {

        }

        #endregion
    }
}

using AutoMapper;
using ProjetoMaster.Application.Interfaces;
using ProjetoMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoMaster.MVC.Controllers
{
    public class PessoaController : Controller
    {
        #region Repositorios

        private readonly IPessoaAppService _pessoaAppService;

        #endregion

        #region Construtor

        public PessoaController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        #endregion

        #region Metodos

        [HttpGet]
        public ActionResult Index()
        {
            var listaPessoa = Mapper.Map(_pessoaAppService.GetAll(), new List<PessoaModelView>());

            return View("PessoaList");
        }

        public ActionResult DeTalhePessoa(int id)
        {
            return View();
        }

        public ActionResult CriarPessoa()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarPessoa(PessoaModelView model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditarPesso(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarPesso(PessoaModelView model)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeletePessoa(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePessoa(PessoaModelView model)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion
    }
}

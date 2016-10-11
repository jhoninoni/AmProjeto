using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ProjetoMaster.Application.Interfaces;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.MVC.ViewsModel;

namespace ProjetoMaster.MVC.Controllers
{
    public class ClienteController : Controller
    {
        //private readonly IClienteAppService _clienteAppService;
        private readonly IPessoaAppService _produtoAppService;

        public ClienteController(IPessoaAppService produtoAppService)
        {
            //_clienteAppService = clienteAppService;
            _produtoAppService = produtoAppService;
        }

        public ActionResult Index()
        {
            //var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppService.GetAll());
            return View();
        }

        public ActionResult Details(int id)
        {
            //var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clienteAppService.GetById(id));
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", "Selecione");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int removerIsso)
        {
            //if (!ModelState.IsValid) return View(model);

            try
            {
                //var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(model);
                //_clienteAppService.Add(clienteDomain);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            //var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clienteAppService.GetById(id));
            ViewBag.ProdutoId = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", "Selecione");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            //if (!ModelState.IsValid) return View(model);

            try
            {
                //var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(model);
                //_clienteAppService.Update(clienteDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            //var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clienteAppService.GetById(id));
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            try
            {
                //_clienteAppService.Remove(_clienteAppService.GetById(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

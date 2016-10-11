using ProjetoMaster.Application.Entities;
using ProjetoMaster.Application.Interfaces;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.Infra.CrossCuting.Criptografar;
using ProjetoMaster.MVC.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoMaster.MVC.Controllers
{
    public class HomeController : Controller
    {
        #region Repositorios

        private readonly IUsuarioAppService _usuarioAppService;
        private readonly IDadosSensorAppService _dadosAppService;

        #endregion

        #region Construtor

        public HomeController(IUsuarioAppService usuarioAppService, IDadosSensorAppService dadosAppService)
        {
            _usuarioAppService = usuarioAppService;
            _dadosAppService = dadosAppService;
        }

        #endregion

        #region Metodos

        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logar(LoginModel model)
        {
            if(!ModelState.IsValid)
                return Index();

            var senha = new Criptografia().Encrypt(model.Senha.Trim()).ToUpper();
            var usuario = _usuarioAppService.GetAll().Where(n => n.Login.ToUpper().Equals(model.Nome.Trim().ToUpper()) && n.Senha.ToUpper().Equals(senha.ToUpper())).ToList();

            if (!usuario.Any())
                return View("Login");

            return View("Index");
        }

        public JsonResult ObterAtividadesRecentes()
        {
            var listaAcessoEscola = new List<DadosSensorDomain>();

            try
            {
                listaAcessoEscola = _dadosAppService.GetAll().OrderByDescending(x => x.DataCadastro).Take(5).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return Json(listaAcessoEscola, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}

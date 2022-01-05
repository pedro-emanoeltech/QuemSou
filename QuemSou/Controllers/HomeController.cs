using QuemSou.Models.Business;
using QuemSou.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuemSou.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Perfil = new PessoasBusiness().Exibir();
            return View(Perfil);
        }

        public ActionResult  editar()
        {
            var Perfil = new PessoasBusiness().Exibir();
            return View(Perfil);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Perfil = new PessoasBusiness().ExibirPerfil(id);
            return View(Perfil);

        }

        [HttpPost]
        public ActionResult Edit(Pessoas pessoas)
        {
            if (new PessoasBusiness().editar(pessoas))
                return RedirectToAction("index");
            else
                return RedirectToAction("PerfilError");

        }

        public JsonResult Listar()
        {
            var lista = new PessoasBusiness().ListarPessoas();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }


    }
}
using QuemSou.Models.Business;
using QuemSou.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuemSou.Controllers
{
    public class FormacaoController : Controller
    {
        // GET: Formacao
        public ActionResult Index()
        {
            var lista = new FormacaoBusiness().ListarFormacao();
            return View(lista);
        }

        public ActionResult Delete(int id)
        {
            if (new FormacaoBusiness().Apagar(id)) 
            return RedirectToAction("index");
            else
                return RedirectToAction("FormacaoERRO");
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View(new Formacao());

        }

        [HttpPost]
        public ActionResult Create(Formacao formacao)
        {
            if (new FormacaoBusiness().Novo(formacao))
                return RedirectToAction("index");
            else
                return RedirectToAction("FormacaoERRO");

        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var formacao = new FormacaoBusiness().ExibirFormacao(id);
            return View(formacao);

        }

        [HttpPost]
        public ActionResult Edit(Formacao formacao)
        {
            if (new FormacaoBusiness().editar(formacao))
                return RedirectToAction("index");
            else
                return RedirectToAction("FormacaoERRO");

        }

        public JsonResult Listar()
        {
            var lista = new FormacaoBusiness().ListarFormacao();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

    }
}
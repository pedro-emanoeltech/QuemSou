using QuemSou.Models.Business;
using QuemSou.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuemSou.Controllers
{
    public class ExperienciaController : Controller
    {
        // GET: Experiencia
        public ActionResult Index()
        {
            var lista = new ExperienciaBusiness().ListarExperiencia();
            return View(lista);
        }
        public ActionResult Delete(int id)
        {
            if (new ExperienciaBusiness().Apagar(id))
                return RedirectToAction("index");
            else
                return RedirectToAction("ExperienciaERRO");
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View(new Experiencia());

        }

        [HttpPost]
        public ActionResult Create(Experiencia experiencia)
        {
            if (new ExperienciaBusiness().Novo(experiencia))
                return RedirectToAction("index");
            else
                return RedirectToAction("ExperienciaERRO");

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var experiencia = new ExperienciaBusiness().ExibirExperiencia(id);
            return View(experiencia);

        }

        [HttpPost]
        public ActionResult Edit(Experiencia experiencia)
        {
            if (new ExperienciaBusiness().editar(experiencia))
                return RedirectToAction("index");
            else
                return RedirectToAction("ExperienciaERRO");


        }
        public JsonResult Listar()
        {
            var lista = new ExperienciaBusiness().ListarExperiencia();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}
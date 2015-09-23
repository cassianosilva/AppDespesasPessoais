using ProjetoDespesaG1_LPOO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoDespesaG1_LPOO2.Controllers
{
    public class HomeController : Controller
    {
        DespesaRepositorio despesaRep = new DespesaRepositorio();
        
        public ActionResult Index()
        {
            return View(despesaRep.getLasts());
        }

        public ActionResult Create()
        {
            ViewBag.Tipos = TipoDespesaRepositorio.GetTipos();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Despesa pDespesa)
        {
            despesaRep.Create(pDespesa);

            return RedirectToAction("Index");
        }

        public ActionResult Update(int Id)
        {
            var editDespesa = despesaRep.getOne(Id);
            DateTime dt = Convert.ToDateTime(editDespesa.DataDespesa);
            editDespesa.DataDespesa = dt.ToString("yyyy-MM-dd");

            return View(editDespesa);
        }

        [HttpPost]
        public ActionResult Update(Despesa pDespesa)
        {
            despesaRep.Update(pDespesa);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            despesaRep.Delete(Id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Pesquisa(string Data)
        {
            return View(despesaRep.getByDate(Data));
        }
    }
}
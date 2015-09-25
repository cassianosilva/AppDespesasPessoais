using ProjetoDespesaG1_LPOO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoDespesaG1_LPOO2.Controllers
{
    public class DespesaController : Controller
    {
        TipoDespesaRepositorio tipoRep = new TipoDespesaRepositorio();
        DespesaRepositorio despesaRep = new DespesaRepositorio();

        public ActionResult Despesas()
        {
            return View(despesaRep.getAll());
        }

        public ActionResult Create()
        {
            ViewBag.Tipos = tipoRep.getAll();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Despesa pDespesa)
        {
            despesaRep.Create(pDespesa);

            return RedirectToAction("Despesas");
        }

        public ActionResult Update(int Id)
        {
            var editDespesa = despesaRep.getOne(Id);
            ViewBag.Tipos = tipoRep.getAllExceptOne(editDespesa.Tipo.idTipo);

            return View(editDespesa);
        }

        [HttpPost]
        public ActionResult Update(Despesa pDespesa)
        {
            despesaRep.Update(pDespesa);

            return RedirectToAction("Despesas");
        }

        public ActionResult Delete(int Id)
        {
            despesaRep.Delete(Id);

            return RedirectToAction("Despesas");
        }

        [HttpPost]
        public ActionResult Pesquisa(string Data)
        {
            return View(despesaRep.getByDate(Data));
        }
    }
}
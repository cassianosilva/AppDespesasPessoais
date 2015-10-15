using ProjetoDespesaG1_LPOO2.Models;
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
    }
}
using Introduccion.Csharp.Models;
using System.Web.Mvc;

namespace Introduccion.Csharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View(new Multiplicacion());
        }

        // POST
        [HttpPost]
        public ActionResult Index(Multiplicacion m)
        {
            m.MostrarMultiplicacion();

            return View(m);
        }
    }
}
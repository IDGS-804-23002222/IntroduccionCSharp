using Introduccion.Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduccion.Csharp.Controllers
{
    public class DistanciaController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View(new Distancia());
        }

        // POST
        [HttpPost]
        public ActionResult Index(Distancia d)
        {
            d.CalcularDistancia();

            return View(d);
        }
    }
}
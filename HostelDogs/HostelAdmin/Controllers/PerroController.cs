using HostelDogSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelAdmin.Controllers
{
    public class PerroController : Controller
    {
        PerroBL perroBL;

        public PerroController()
        {
            perroBL = new PerroBL();
        }

        // GET: Perro
        public ActionResult Index()
        {
            var perros = perroBL.ObtenerPerro();

            return View(perros);
        }


        public ActionResult Create()
        {
            var perro = new Perro();

            return View(perro);
        }

        [HttpPost]
        public ActionResult Create(Perro perro)
        {
            if (ModelState.IsValid)
            {
                perroBL.GuardarPerros(perro);

                return RedirectToAction("Index");
            }

            return View(perro);
        }
    }
}
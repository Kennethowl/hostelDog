using HostelDogSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelAdmin.Controllers
{
    public class RazaController : Controller
    {
        RazaBL razaBL;

        public RazaController()
        {
            razaBL = new RazaBL();
        }

        // GET: Raza
        public ActionResult Index()
        {
            var ListaDeRazas = razaBL.ObtenerRaza();

            return View(ListaDeRazas);
        }

        public ActionResult Create()
        {
            var raza = new Raza();
                
            return View(raza);
        }

        [HttpPost]
        public ActionResult Create(Raza raza)
        {
            if (ModelState.IsValid)
            {
                if (raza.Descripcion != raza.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "No debe contener espacios al inicio, ni al final");
                }

                razaBL.GuardarRaza(raza);

                return RedirectToAction("Index");
            }

            return View(raza);
        }

        public ActionResult Edit(int id)
        {
            var raza = razaBL.ObtenerRazas(id);

            return View(raza);
        }

        [HttpPost]
        public ActionResult Edit(Raza raza)
        {
            if (ModelState.IsValid)
            {
                if (raza.Descripcion != raza.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "No debe contener espacios al inicio, ni al final");
                }

                razaBL.GuardarRaza(raza);

                return RedirectToAction("Index");
            }

            return View(raza);
        }

        public ActionResult Details(int id)
        {
            var raza = razaBL.ObtenerRazas(id);

            return View(raza);
        }

        public ActionResult Delete(int id)
        {
            var raza = razaBL.ObtenerRazas(id);

            return View(raza);
        }

        [HttpPost]
        public ActionResult Delete(Raza raza)
        {
            razaBL.EliminarRazas(raza.ID);

            return RedirectToAction("Index");
        }
    }
}
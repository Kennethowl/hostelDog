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
        public ActionResult Create(Perro perro, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (imagen != null)
                {
                    perro.Imagen = GuardarImagen(imagen);
                }

                perroBL.GuardarPerros(perro);

                return RedirectToAction("Index");
            }

            return View(perro);
        }

        public ActionResult Edit(int id)
        {
            var perro = perroBL.ObtenerPerros(id);

            return View(perro);
        }

        [HttpPost]
        public ActionResult Edit(Perro perro,HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (imagen != null)
                {
                    perro.Imagen = GuardarImagen(imagen);
                }

                perroBL.GuardarPerros(perro);

                return RedirectToAction("Index");
            }

            return View(perro);
        }

        public ActionResult Details(int id)
        {
            var perro = perroBL.ObtenerPerros(id);

            return View(perro);
        }

        public ActionResult Delete(int id)
        {
            var perro = perroBL.ObtenerPerros(id);

            return View(perro);
        }

        [HttpPost]
        public ActionResult Delete(Perro perro)
        {
            perroBL.EliminarPerros(perro.ID);

            return RedirectToAction("Index");
        }

        public string GuardarImagen(HttpPostedFileBase imagen)
        {
            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);

            return "/Imagenes/" + imagen.FileName;
        }
    }
}
using GAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAP.Controllers
{
    public class PolizaController : Controller
    {
        // GET: Poliza
        public ActionResult Index()
        {
            return View();
        }

        // GET: Poliza/Details/5
        [Authorize]
        public ActionResult Details()
        {        
            var Poliza = new Poliza { NombrePoliza = "Poliza Automovil", DescripcionPoliza="La poliza de automovil cubre descripcion", FechaInicio=DateTime.Now, NumeroMesesCobertura=24, Precio=1200000, ApplicationUserId=User.Identity.Name, idTipoCobertura= 1, idTipoRiesgo=2, idTipoEstado= 1};
            return View(Poliza);        
        }

        // GET: Poliza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Poliza/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var Poliza = new Poliza { NombrePoliza = "Poliza Automovil", DescripcionPoliza = "La poliza de automovil cubre descripcion", FechaInicio = DateTime.Now, NumeroMesesCobertura = 24, Precio = 1200000, ApplicationUserId = User.Identity.Name, idTipoCobertura = 2, idTipoRiesgo = 2, idTipoEstado = 1 };

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Poliza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Poliza/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Poliza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Poliza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

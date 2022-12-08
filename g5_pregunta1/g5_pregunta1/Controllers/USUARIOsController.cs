using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using g5_pregunta1.Models;

namespace g5_pregunta1.Controllers
{
    public class USUARIOsController : Controller
    {
        private G5_CASO3Entities db = new G5_CASO3Entities();

        // GET: USUARIOs
        [Authorize]
        public ActionResult Index()
        {
            return View(db.USUARIO.ToList());
        }

        // GET: USUARIOs/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = db.USUARIO.Find(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // GET: USUARIOs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: USUARIOs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(g5_pregunta1.Models.ViewModel.USUARIOModelo model)
        {
            if (ModelState.IsValid)
            {
                USUARIO usu = new USUARIO();
                usu.ID_USUARIO = model.ID_USUARIO;
                usu.EMAIL = model.EMAIL;
                usu.PASS = model.PASS;
                usu.FECHA_ULTIMO_ACCESO = model.FECHA_ULTIMO_ACCESO;
                db.USUARIO.Add(usu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        // GET: USUARIOs/Create
        public ActionResult Registro()
        {
            return View();
        }

        // POST: USUARIOs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(g5_pregunta1.Models.ViewModel.USUARIOModelo model)
        {
            if (ModelState.IsValid)
            {
                USUARIO usu = new USUARIO();
                usu.ID_USUARIO = model.ID_USUARIO;
                usu.EMAIL = model.EMAIL;
                usu.PASS = model.PASS;
                usu.FECHA_ULTIMO_ACCESO = model.FECHA_ULTIMO_ACCESO;
                db.USUARIO.Add(usu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Registro");
        }

        // GET: USUARIOs/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = db.USUARIO.Find(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // POST: USUARIOs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID_USUARIO,EMAIL,PASS,FECHA_ULTIMO_ACCESO")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSUARIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uSUARIO);
        }

        // GET: USUARIOs/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = db.USUARIO.Find(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // POST: USUARIOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            USUARIO uSUARIO = db.USUARIO.Find(id);
            db.USUARIO.Remove(uSUARIO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

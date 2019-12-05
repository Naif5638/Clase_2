using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD_DiplomadoCodeFirst.Models.DAL;
using MVC_CRUD_DiplomadoCodeFirst.Models.Models;

namespace MVC_CRUD_DiplomadoCodeFirst.Web.Controllers
{
    public class InscripcionController : Controller
    {
        private CarreraContext db = new CarreraContext();

        // GET: Inscripcion
        public ActionResult Index()
        {
            var inscripciones = db.Inscripciones.Include(i => i.Coursos).Include(i => i.Estudiantes);
            return View(inscripciones.ToList());
        }

        // GET: Inscripcion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            if (inscripcion == null)
            {
                return HttpNotFound();
            }
            return View(inscripcion);
        }

        // GET: Inscripcion/Create
        public ActionResult Create()
        {
            ViewBag.CursoId = new SelectList(db.Coursos, "CursoId", "Descripcion");
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "EstudianteId", "Nombres");
            return View();
        }

        // POST: Inscripcion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InscripcionId,CursoId,EstudianteId,Semestre")] Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                db.Inscripciones.Add(inscripcion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CursoId = new SelectList(db.Coursos, "CursoId", "Descripcion", inscripcion.CursoId);
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "EstudianteId", "Nombres", inscripcion.EstudianteId);
            return View(inscripcion);
        }

        // GET: Inscripcion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            if (inscripcion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoId = new SelectList(db.Coursos, "CursoId", "Descripcion", inscripcion.CursoId);
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "EstudianteId", "Nombres", inscripcion.EstudianteId);
            return View(inscripcion);
        }

        // POST: Inscripcion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InscripcionId,CursoId,EstudianteId,Semestre")] Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inscripcion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CursoId = new SelectList(db.Coursos, "CursoId", "Descripcion", inscripcion.CursoId);
            ViewBag.EstudianteId = new SelectList(db.Estudiantes, "EstudianteId", "Nombres", inscripcion.EstudianteId);
            return View(inscripcion);
        }

        // GET: Inscripcion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            if (inscripcion == null)
            {
                return HttpNotFound();
            }
            return View(inscripcion);
        }

        // POST: Inscripcion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            db.Inscripciones.Remove(inscripcion);
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

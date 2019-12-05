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
    public class CoursoController : Controller
    {
        private CarreraContext db = new CarreraContext();

        // GET: Courso
        public ActionResult Index()
        {
            return View(db.Coursos.ToList());
        }

        // GET: Courso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courso courso = db.Coursos.Find(id);
            if (courso == null)
            {
                return HttpNotFound();
            }
            return View(courso);
        }

        // GET: Courso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CursoId,Descripcion")] Courso courso)
        {
            if (ModelState.IsValid)
            {
                db.Coursos.Add(courso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courso);
        }

        // GET: Courso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courso courso = db.Coursos.Find(id);
            if (courso == null)
            {
                return HttpNotFound();
            }
            return View(courso);
        }

        // POST: Courso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CursoId,Descripcion")] Courso courso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courso);
        }

        // GET: Courso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courso courso = db.Coursos.Find(id);
            if (courso == null)
            {
                return HttpNotFound();
            }
            return View(courso);
        }

        // POST: Courso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Courso courso = db.Coursos.Find(id);
            db.Coursos.Remove(courso);
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

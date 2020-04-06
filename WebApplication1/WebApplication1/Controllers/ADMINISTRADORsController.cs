using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class ADMINISTRADORsController : Controller
    {
        private COURRIEREntities1 db = new COURRIEREntities1();

        // GET: ADMINISTRADORs
        public ActionResult Index()
        {
            return View(db.ADMINISTRADOR.ToList());
        }

        // GET: ADMINISTRADORs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRADOR aDMINISTRADOR = db.ADMINISTRADOR.Find(id);
            if (aDMINISTRADOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRADOR);
        }

        // GET: ADMINISTRADORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ADMINISTRADORs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,USERNAME,CLAVE")] ADMINISTRADOR aDMINISTRADOR)
        {
            if (ModelState.IsValid)
            {
                db.ADMINISTRADOR.Add(aDMINISTRADOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aDMINISTRADOR);
        }

        // GET: ADMINISTRADORs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRADOR aDMINISTRADOR = db.ADMINISTRADOR.Find(id);
            if (aDMINISTRADOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRADOR);
        }

        // POST: ADMINISTRADORs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,USERNAME,CLAVE")] ADMINISTRADOR aDMINISTRADOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aDMINISTRADOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aDMINISTRADOR);
        }

        // GET: ADMINISTRADORs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADMINISTRADOR aDMINISTRADOR = db.ADMINISTRADOR.Find(id);
            if (aDMINISTRADOR == null)
            {
                return HttpNotFound();
            }
            return View(aDMINISTRADOR);
        }

        // POST: ADMINISTRADORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ADMINISTRADOR aDMINISTRADOR = db.ADMINISTRADOR.Find(id);
            db.ADMINISTRADOR.Remove(aDMINISTRADOR);
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

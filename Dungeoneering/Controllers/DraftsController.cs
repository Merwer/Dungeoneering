using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dungeoneering.Models;
using Merwer.Chronicle.Dungeoneering.Tracker.Api.Models;

namespace Dungeoneering.Controllers
{
    public class DraftsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Drafts
        public ActionResult Index()
        {
            return View(db.Drafts.ToList());
        }

        // GET: Drafts/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Draft draft = db.Drafts.Find(id);
            if (draft == null)
            {
                return HttpNotFound();
            }
            return View(draft);
        }

        // GET: Drafts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drafts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Archetype,PublicId,CreatedOn")] Draft draft)
        {
            if (ModelState.IsValid)
            {
                db.Drafts.Add(draft);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(draft);
        }

        // GET: Drafts/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Draft draft = db.Drafts.Find(id);
            if (draft == null)
            {
                return HttpNotFound();
            }
            return View(draft);
        }

        // POST: Drafts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Archetype,PublicId,CreatedOn")] Draft draft)
        {
            if (ModelState.IsValid)
            {
                db.Entry(draft).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(draft);
        }

        // GET: Drafts/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Draft draft = db.Drafts.Find(id);
            if (draft == null)
            {
                return HttpNotFound();
            }
            return View(draft);
        }

        // POST: Drafts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Draft draft = db.Drafts.Find(id);
            db.Drafts.Remove(draft);
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

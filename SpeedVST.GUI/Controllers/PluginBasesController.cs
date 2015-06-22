using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpeedVST.App.Entities;
using SpeedVST.GUI.Models;

namespace SpeedVST.GUI.Controllers
{
    public class PluginBasesController : Controller
    {
        private PluginDataBase db = new PluginDataBase();

        // GET: PluginBases
        public ActionResult Index()
        {
            return View(db.PluginData.ToList());
        }

        // GET: PluginBases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PluginBase pluginBase = db.PluginData.Find(id);
            if (pluginBase == null)
            {
                return HttpNotFound();
            }
            return View(pluginBase);
        }

        // GET: PluginBases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PluginBases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Author,Cat,ReleaseDate,Price")] PluginBase pluginBase)
        {
            if (ModelState.IsValid)
            {
                db.PluginData.Add(pluginBase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pluginBase);
        }

        // GET: PluginBases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PluginBase pluginBase = db.PluginData.Find(id);
            if (pluginBase == null)
            {
                return HttpNotFound();
            }
            return View(pluginBase);
        }

        // POST: PluginBases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Author,Cat,ReleaseDate,Price")] PluginBase pluginBase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pluginBase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pluginBase);
        }

        // GET: PluginBases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PluginBase pluginBase = db.PluginData.Find(id);
            if (pluginBase == null)
            {
                return HttpNotFound();
            }
            return View(pluginBase);
        }

        // POST: PluginBases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PluginBase pluginBase = db.PluginData.Find(id);
            db.PluginData.Remove(pluginBase);
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

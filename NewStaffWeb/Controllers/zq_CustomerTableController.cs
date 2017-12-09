using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewStaffWeb.Models;

namespace NewStaffWeb.Controllers
{
    public class zq_CustomerTableController : Controller
    {
        private Customer db = new Customer();

        // GET: zq_CustomerTable
        public ActionResult Index()
        {
            return View(db.zq_CustomerTable.ToList());
        }

        // GET: zq_CustomerTable/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            zq_CustomerTable zq_CustomerTable = db.zq_CustomerTable.Find(id);
            if (zq_CustomerTable == null)
            {
                return HttpNotFound();
            }
            return View(zq_CustomerTable);
        }

        // GET: zq_CustomerTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: zq_CustomerTable/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,customerName,customerPhone,customerMessage")] zq_CustomerTable zq_CustomerTable)
        {
            if (ModelState.IsValid)
            {
                db.zq_CustomerTable.Add(zq_CustomerTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zq_CustomerTable);
        }

        // GET: zq_CustomerTable/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            zq_CustomerTable zq_CustomerTable = db.zq_CustomerTable.Find(id);
            if (zq_CustomerTable == null)
            {
                return HttpNotFound();
            }
            return View(zq_CustomerTable);
        }

        // POST: zq_CustomerTable/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,customerName,customerPhone,customerMessage")] zq_CustomerTable zq_CustomerTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zq_CustomerTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zq_CustomerTable);
        }

        // GET: zq_CustomerTable/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            zq_CustomerTable zq_CustomerTable = db.zq_CustomerTable.Find(id);
            if (zq_CustomerTable == null)
            {
                return HttpNotFound();
            }
            return View(zq_CustomerTable);
        }

        // POST: zq_CustomerTable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            zq_CustomerTable zq_CustomerTable = db.zq_CustomerTable.Find(id);
            db.zq_CustomerTable.Remove(zq_CustomerTable);
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

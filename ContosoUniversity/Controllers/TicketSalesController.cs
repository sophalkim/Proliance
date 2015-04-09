using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    public class TicketSalesController : Controller
    {
        private TicketSalesDbContext db = new TicketSalesDbContext();

        // GET: TicketSales
        public ActionResult Index(string searchString)
        {
            var tickets = from t in db.TicketSales
                          select t;
            ViewBag.searchString = searchString;
            return View(tickets);
        }

        // GET: TicketSales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketSales ticketSales = db.TicketSales.Find(id);
            if (ticketSales == null)
            {
                return HttpNotFound();
            }
            return View(ticketSales);
        }

        // GET: TicketSales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketSales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date,Amount")] TicketSales ticketSales)
        {
            if (ModelState.IsValid)
            {
                db.TicketSales.Add(ticketSales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ticketSales);
        }

        // GET: TicketSales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketSales ticketSales = db.TicketSales.Find(id);
            if (ticketSales == null)
            {
                return HttpNotFound();
            }
            return View(ticketSales);
        }

        // POST: TicketSales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date,Amount")] TicketSales ticketSales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticketSales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ticketSales);
        }

        // GET: TicketSales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketSales ticketSales = db.TicketSales.Find(id);
            if (ticketSales == null)
            {
                return HttpNotFound();
            }
            return View(ticketSales);
        }

        // POST: TicketSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TicketSales ticketSales = db.TicketSales.Find(id);
            db.TicketSales.Remove(ticketSales);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Code.App_Data;
using Code.Models;

namespace Code.Controllers
{
    public class PersonInformationsController : Controller
    {
        private Context db = new Context();

        // GET: PersonInformations
        public ActionResult Index()
        {
            return View(db.PersonInformations.ToList());
        }

        // GET: PersonInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonInformation personInformation = db.PersonInformations.Find(id);
            if (personInformation == null)
            {
                return HttpNotFound();
            }
            return View(personInformation);
        }

        // GET: PersonInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PFirstName,PLastName,PStreetAddress,PPostalCode,PCity,PPersonalNumber,PPhoneNumberHome,PPhoneNumberWork,PPhoneNumberMobile,PEmail,SFirstName,SLastName,SStreetAddress,SPostalCode,SCity,SOrganisationNumber,SPhoneNumber,SEmail")] PersonInformation personInformation)
        {
            if (ModelState.IsValid)
            {
                db.PersonInformations.Add(personInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personInformation);
        }

        // GET: PersonInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonInformation personInformation = db.PersonInformations.Find(id);
            if (personInformation == null)
            {
                return HttpNotFound();
            }
            return View(personInformation);
        }

        // POST: PersonInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PFirstName,PLastName,PStreetAddress,PPostalCode,PCity,PPersonalNumber,PPhoneNumberHome,PPhoneNumberWork,PPhoneNumberMobile,PEmail,SFirstName,SLastName,SStreetAddress,SPostalCode,SCity,SOrganisationNumber,SPhoneNumber,SEmail")] PersonInformation personInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personInformation);
        }

        // GET: PersonInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonInformation personInformation = db.PersonInformations.Find(id);
            if (personInformation == null)
            {
                return HttpNotFound();
            }
            return View(personInformation);
        }

        // POST: PersonInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonInformation personInformation = db.PersonInformations.Find(id);
            db.PersonInformations.Remove(personInformation);
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

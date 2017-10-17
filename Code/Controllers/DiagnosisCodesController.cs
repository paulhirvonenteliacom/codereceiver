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
    public class DiagnosisCodesController : Controller
    {
        private Context db = new Context();

        // GET: DiagnosisCodes
        public ActionResult PersonInformation()
        {
            return View();
        }

        // GET: DiagnosisCodes
        public ActionResult Index()
        {
            return View(db.DiagnosisCodes.ToList());
        }

        // GET: DiagnosisCodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiagnosisCode diagnosisCode = db.DiagnosisCodes.Find(id);
            if (diagnosisCode == null)
            {
                return HttpNotFound();
            }
            return View(diagnosisCode);
        }

        // GET: DiagnosisCodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiagnosisCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DiagnosisCode1,DiagnosisDescription1,DiagnosisCode2,DiagnosisDescription2," +
                                                    "TreatmentCode1,TreatmentDescription1,TreatmentCode2,TreatmentDescription2,TreatmentCode3," +
                                                    "TreatmentDescription3,TreatmentCode4,TreatmentDescription4")] DiagnosisCode diagnosisCode)
        {
            if (ModelState.IsValid)
            {
                db.DiagnosisCodes.Add(diagnosisCode);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(diagnosisCode);
        }

        // GET: DiagnosisCodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiagnosisCode diagnosisCode = db.DiagnosisCodes.Find(id);
            if (diagnosisCode == null)
            {
                return HttpNotFound();
            }
            return View(diagnosisCode);
        }

        // POST: DiagnosisCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DiagnosisCode1,DiagnosisCode2,TreatmentCode1,TreatmentCode2,TreatmentCode3,TreatmentCode4")] DiagnosisCode diagnosisCode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diagnosisCode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diagnosisCode);
        }

        // GET: DiagnosisCodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiagnosisCode diagnosisCode = db.DiagnosisCodes.Find(id);
            if (diagnosisCode == null)
            {
                return HttpNotFound();
            }
            return View(diagnosisCode);
        }

        // POST: DiagnosisCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiagnosisCode diagnosisCode = db.DiagnosisCodes.Find(id);
            db.DiagnosisCodes.Remove(diagnosisCode);
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

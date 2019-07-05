using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FullCodeBasedTest.Models;
using X.PagedList.Mvc;
using X.PagedList;

namespace FullCodeBasedTest.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        DemoDatabaseEntities db = new DemoDatabaseEntities();
        public ActionResult Index(string search, int? i)
        {
            if (!String.IsNullOrEmpty(search))
            {
                return View(db.Fun_ViewPersons().Where(item => item.Name.StartsWith(search) || search == null).ToList().ToPagedList(i ?? 1, 5));
            }
            return View(db.Fun_ViewPersons().ToList().ToPagedList(i ?? 1, 5));
        }

        public ActionResult Create()
        {
            List<TblCity> list = new List<TblCity>();
            list = db.Fun_ViewCity().ToList();
            ViewBag.City = new SelectList(list, "CityId", "CityName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(TblPerson tblPerson)
        {
            if (ModelState.IsValid)
            {
                //db.Fun_InsertPerson(null, tblPerson.Name, tblPerson.Email, tblPerson.Mobile, tblPerson.Course, tblPerson.Percentage, tblPerson.Address, tblPerson.City);
                db.TblPersons.Add(tblPerson);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            List<TblCity> list = new List<TblCity>();
            list = db.Fun_ViewCity().ToList();
            ViewBag.City = new SelectList(list, "CityId", "CityName");
            return View();
        }

        public ActionResult AddCity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCity(TblCity tblCity)
        {
            if (ModelState.IsValid)
            {
                //db.Fun_InsertCity(null, tblCity.CityName);
                db.TblCities.Add(tblCity);
                db.SaveChanges();
                return RedirectToAction("Create", "Home");
            }
            return View();
        }

        // Delete on get method
        public ActionResult Delete(int? id)
        {
            try
            {
                db.TblPersons.Remove(db.TblPersons.Find(id));
                db.SaveChanges();
            }
            catch
            {
                // Nothing to do
            }
            return RedirectToAction("Index");
        }
    }
}
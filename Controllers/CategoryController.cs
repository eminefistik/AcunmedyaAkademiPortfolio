using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        AcunmedyaAkademi1 db = new AcunmedyaAkademi1();
        public ActionResult CategoryList()
        {
            var values = db.catagorytbl.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(catagorytbl category) 
        {
            db.catagorytbl.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id) 
        {
            var value = db.catagorytbl.Find(id);
            db.catagorytbl.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
      
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id) 
        {
            var value = db.catagorytbl.Find(id);
            return View(value);
        
        }

        [HttpPost]
        public ActionResult UpdateCategory(catagorytbl p) 
        {
            var value = db.catagorytbl.Find(p.categoryId);
            value.catagoryName =p.catagoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");


        }

    }
}
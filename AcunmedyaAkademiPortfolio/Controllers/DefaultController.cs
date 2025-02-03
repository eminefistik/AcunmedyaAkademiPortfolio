using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;


namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        AcunmedyaAkademi1 db = new AcunmedyaAkademi1();


        public PartialViewResult PartialProject()
        {
            var values = db.tblproject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServiced()
        {
            var values = db.TblServiced.ToList();
            return PartialView(values);
        }

        public PartialViewResult Partialtestimoniall()
        {
            var values = db.Tbltestimoniall.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMessage()
        {
            var values = db.TblMessage.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialEducation()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialExperience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
       

        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }


        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead() 
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeroSection()
        {
            return PartialView();
        }
    }
}
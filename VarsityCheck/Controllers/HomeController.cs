using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VarsityCheck.ViewModels;

namespace VarsityCheck.Controllers
{
    public class HomeController : Controller
    {
        TheDbContext theDbcontext = new TheDbContext();
        DisplayViews display = new DisplayViews();       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bursary()
        {
            display.fields = theDbcontext.fields.ToList();
            display.financialAids = theDbcontext.financialAids.ToList();
            display.financialAidsFields = theDbcontext.FinancialAidFields.ToList();

            return View(display);
        }

        public ActionResult CareerPath()
        {

            return View();
        }
        public ActionResult Degrees()
        {
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();            
            display.degrees = theDbcontext.degrees.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();

            return View(display);
        }

        public ActionResult Diploma()
        {
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Certification()
        {
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }

        public ActionResult Learnership()
        {
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult University()
        {

            return View();
        }
        public ActionResult Application()
        {

            return View();
        }
        
        public ActionResult GovernmentSector()
        {

            return View();
        }
    }
}
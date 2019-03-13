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

            return View();
        }
        public ActionResult GovernmentSector()
        {

            return View();
        }

        public ActionResult CareerSelection()
        {
            return View();
        }
    }
}
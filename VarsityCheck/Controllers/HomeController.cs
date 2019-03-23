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
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

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
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult UniversityList()
        {
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();


            return View(display);
        }
        public ActionResult Application()
        {
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();


            return View(display);
        }
        
        public ActionResult Electrical()
        {
            ViewBag.Name = "UNIVERSITIES OFFERING ELECTRICAL ENGINEERING";
            ViewBag.degreeName = "Electrical Engineering";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Mining()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES MINNG ENGINEERING";
            ViewBag.degreeName = "Mining Engineering";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Mechanical()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES MECHANICAL ENGINEERING";
            ViewBag.degreeName = "Mechanical Engineering";


            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Industrial()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES INDUSTRIAL ENGINEERING";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Chemical()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES CHEMICAL ENGINEERING";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }

    }
}
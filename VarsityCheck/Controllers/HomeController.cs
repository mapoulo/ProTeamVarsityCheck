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
            ViewBag.Name = "Financial Aid";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();
            display.financialAids = theDbcontext.financialAids.ToList();

            return View(display);
        }

        public ActionResult CareerPath()
        {
            ViewBag.Name = "Career Path";

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
            ViewBag.Name = "DIPLOMA";

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
            ViewBag.Name = "LEARNERSHIP";

            display.financialAids = theDbcontext.financialAids.ToList();
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();
            display.learnerships = theDbcontext.learnerships.ToList();


            return View(display);
        }
        public ActionResult University()
        {

            ViewBag.Name = "LIST OF SOUTH AFRICAN UNIVERSITIES";

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
        public ActionResult GovernmentSector()
        {
            ViewBag.Name = "GOVERNMENT OPPORTUNITIES";

            display.financialAids = theDbcontext.financialAids.ToList();
            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();
            display.governmentSectors = theDbcontext.governmentSectors.ToList();

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
            ViewBag.degreeName = "Industrial Engineering";

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
            ViewBag.degreeName = "Chemical Engineering";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Extraction()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES EXTRACTION ENGINEERING";
            ViewBag.degreeName = "Extraction Engineering";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Physical()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES PHYSICAL ENGINEERING";
            ViewBag.degreeName = "Physical Engineering";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Civil()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES CIVIL ENGINEERING";
            ViewBag.degreeName = "Civil Engineering";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Mangement()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES & COLLEGES OFFERING MANAGEMENT SERVICES";
            ViewBag.degreeName = "Mangement Services";

            display.faculties = theDbcontext.faculties.ToList();
            display.universities = theDbcontext.universities.ToList();
            display.universityFaculties = theDbcontext.universityFaculties.ToList();
            display.schools = theDbcontext.schools.ToList();
            display.diplomas = theDbcontext.diplomas.ToList();
            display.degrees = theDbcontext.degrees.ToList();

            return View(display);
        }
        public ActionResult Operations()
        {
            ViewBag.Name = "LIST OF UNIVERSITIES & COLLEGES OFFERING OPARATIONS MANAGEMENT";
            ViewBag.degreeName = "Operations Management";

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

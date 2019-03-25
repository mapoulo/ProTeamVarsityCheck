using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class UniversityFaculty
    {
        public int UniversityId { get; set; }
      
        public University Universities { get; set; }

        public int FacultyId { get; set; }
        public Faculty Faculties { get; set; }
        public string Url { get; set; }

    }

}
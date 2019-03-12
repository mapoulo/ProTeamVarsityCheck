using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<UniversityFaculty> UniversityFacultyList { get; set; }
    }
}
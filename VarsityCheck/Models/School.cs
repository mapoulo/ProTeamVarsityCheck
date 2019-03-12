using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculties { get; set; }
        public int FacultyId { get; set; }
        public ICollection<Diploma> diplomasList { get; set; }
        public ICollection<Degree> degreesList { get; set; }
    }
}
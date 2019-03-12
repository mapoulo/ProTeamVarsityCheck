using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VarsityCheck.Models;

namespace VarsityCheck.ViewModels
{
    public class DisplayViews
    {
        public ICollection<University> universities { get; set; }
        public ICollection<UniversityFaculty> universityFaculties { get; set; }
        public ICollection<Faculty> faculties { get; set; }
        public ICollection<School> schools { get; set; }
        public ICollection<Degree> degrees { get; set; }
        public ICollection<Diploma> diplomas { get; set; }
        public ICollection<DisplayViews> displayViewList { get; set; }
        public ICollection<Field> fields { get; set; }
        public ICollection<FinancialAid> financialAids { get; set; }
        public ICollection<FinancialAidField> financialAidsFields { get; set; }
    }
}
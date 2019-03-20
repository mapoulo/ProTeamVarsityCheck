using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FinancialAidField> FinancialAidFieldsList { get; set; }
        public ICollection<CollegeField> CollegeFieldList { get; set; }
        public ICollection<Certificate> CertificatesList { get; set; }
        public ICollection<GovernmentSectorField> GovernmentSectorFieldsList { get; set; }
        public string Image { get; set; }

    }
}
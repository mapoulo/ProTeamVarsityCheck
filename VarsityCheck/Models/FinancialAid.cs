using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class FinancialAid
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string BursaryName { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public string URL { get; set; }
        public ICollection<FinancialAidField> FinancialAidFieldsList { get; set; }
        public string Image { get; set; }
    }
}
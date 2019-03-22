using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class CareerOpportunity
    {
        public int Id { get; set; }
        public int DegreeID { get; set; }
        public Degree Degree { get; set; }
        public string Careers { get; set; }
    }
}
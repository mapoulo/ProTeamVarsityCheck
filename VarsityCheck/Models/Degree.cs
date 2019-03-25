using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class Degree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public School Schools { get; set; }
        public Discriptions  Discriptions { get; set; }
        public CareerOpportunity CareerOpportunity { get; set; }
        public int SchoolId { get; set; }
        public string Image { get; set; }
        public string Links { get; set; }

    }
}
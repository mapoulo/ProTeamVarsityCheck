using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class Discriptions
    {
        public int Id { get; set; }
        public int UniversityId { get; set; }
        public int DegreesId { get; set; }
        public University University { get; set; }
        public Degree Degree { get; set; }        
        public string Overview { get; set; }
        public string  Link { get; set; }
    }
}
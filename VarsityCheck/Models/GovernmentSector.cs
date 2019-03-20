using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class GovernmentSector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public string  url { get; set; }
        public ICollection<GovernmentSectorField> GovernmentSectorFieldsList { get; set; }
        public string Image { get; set; }
    }
}
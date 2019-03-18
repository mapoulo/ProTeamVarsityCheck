using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class GovernmentSectorField
    {
        public int FieldId { get; set; }
        public Field Field { get; set; }
        public int GovernmentId { get; set; }
        public GovernmentSector GovernmentSector { get; set; }
    }
}
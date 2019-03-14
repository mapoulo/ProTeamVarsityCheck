using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class CollegeField
    {
        public int FieldId { get; set; }
        public Field Field { get; set; }
        public int CollegeId { get; set; }
        public Colleges Colleges { get; set; }
    }
}
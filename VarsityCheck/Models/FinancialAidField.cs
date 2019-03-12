using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class FinancialAidField
    {
        public int FieldId { get; set; }
        public Field Field { get; set; }
        public int FinancialAidId { get; set; }
        public FinancialAid FinancialAid { get; set; }

    }
}
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
    }
}
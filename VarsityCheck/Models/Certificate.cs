﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class Certificate
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public Field Field { get; set; }
        public int FieldId { get; set; }
        public ICollection<LearnershipCertificate> LearnershipCertificateList { get; set; }
    }
}
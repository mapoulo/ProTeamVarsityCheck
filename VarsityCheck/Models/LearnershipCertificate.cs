using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class LearnershipCertificate
    {
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        public int LearnershipId { get; set; }
        public Learnership Learnership { get; set; }
    }
}
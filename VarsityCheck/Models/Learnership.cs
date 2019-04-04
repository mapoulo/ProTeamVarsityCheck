using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsityCheck.Models
{
    public class Learnership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Certificate> CertificatesList { get; set; }
        public ICollection<LearnershipCertificate> LearnershipCertificateList { get; set; }
        public string Image { get; set; }
        public string UrlApply { get; set; }
        public string LearnershipNames { get; set; }

    }
}
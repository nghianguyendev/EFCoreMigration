using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMigration.DataAccess.Entities
{
    public class EmployeeCertificate
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMigration.DataAccess.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<EmployeeCertificate> EmployeeCertificates { get; set; }
    }
}

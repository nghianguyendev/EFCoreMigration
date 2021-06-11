using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMigration.DataAccess.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}

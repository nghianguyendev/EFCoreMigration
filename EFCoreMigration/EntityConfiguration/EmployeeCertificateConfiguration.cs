using System;
using System.Collections.Generic;
using System.Text;

using EFCoreMigration.DataAccess.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMigration.DataAccess.EntityConfiguration
{
    public class EmployeeCertificateConfiguration : IEntityTypeConfiguration<EmployeeCertificate>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificate> builder)
        {
            builder.HasKey(x => new { x.EmployeeId, x.CertificateId });
        }
    }
}

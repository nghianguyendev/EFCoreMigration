using System;
using System.Collections.Generic;
using System.Text;

using EFCoreMigration.DataAccess.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMigration.DataAccess.EntityConfiguration
{
    public class CertificateLocationConfiguration : IEntityTypeConfiguration<CertificateLocation>
    {
        public void Configure(EntityTypeBuilder<CertificateLocation> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}

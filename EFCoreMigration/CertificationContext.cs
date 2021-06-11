using System;

using EFCoreMigration.DataAccess.EntityConfiguration;

using Microsoft.EntityFrameworkCore;

namespace EFCoreMigration
{
    public class CertificationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.2.26; Database=OtherSample;User Id=sa;Password=123456@A");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new CertificateConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeCertificateConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

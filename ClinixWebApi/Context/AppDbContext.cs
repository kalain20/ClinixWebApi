using ClinixWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinixWebApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Doctor>().ToTable("doctors");
            modelBuilder.Entity<Nurse>().ToTable("nurses");
            modelBuilder.Entity<Beneficiary>().ToTable("beneficiary");
            modelBuilder.Entity<Localization>().ToTable("localization");
            modelBuilder.Entity<Instruction>().ToTable("instruction");
            modelBuilder.Entity<Patient>().ToTable("patients");
            modelBuilder.Entity<Prescription>().ToTable("prescription");
        }
    }
}

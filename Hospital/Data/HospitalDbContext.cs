using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base("hospitalConnection") { }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<EducationInformation> EducationInformation { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Illness> Illnesses { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasOptional(s => s.Appointment)
                .WithRequired(ad => ad.Patient);
            modelBuilder.Entity<Doctor>()
                .HasOptional(s => s.Schedule)
                .WithRequired(ad => ad.Doctor);
        }
    }
}
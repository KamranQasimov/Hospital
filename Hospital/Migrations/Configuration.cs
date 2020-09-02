namespace Hospital.Migrations
{
    using Hospital.Data;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hospital.Data.HospitalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hospital.Data.HospitalDbContext context)
        {
            string email = ConfigurationManager.AppSettings["email"];
            string password = ConfigurationManager.AppSettings["password"];
            string username = ConfigurationManager.AppSettings["username"];

            context.AppUsers.AddOrUpdate(new AppUser
            {
                Id = 1,
                Password = password,
                Username = username,
                UserType = UserType.Admin
            }, new AppUser
            {
                Id = 2,
                Password = "doctor12345",
                Username = "doctor1",
                UserType = UserType.Doctor
            }, new AppUser
            {
                Id = 3,
                Password = "doctor54321",
                Username = "doctor2",
                UserType = UserType.Doctor
            });
            context.Employees.AddOrUpdate(new Employee
            {
                Id = 1,
                AppUserId = 1,
                Email = email,
                IsActive = true,
                Name = "Telman",
                Phone = "+994554554565",
                Surname = "Yusifov",
                JoiningDate = DateTime.Now
            }, new Employee
            {
                Id = 2,
                AppUserId = 2,
                Email = "Doctorone@gmail.com",
                IsActive = true,
                Name = "Elekber",
                Phone = "+994557380385",
                Surname = "Elekberov",
                JoiningDate = DateTime.Now
            }, new Employee
            {
                Id = 3,
                AppUserId = 3,
                Email = "Doctortwo@gmail.com",
                IsActive = true,
                Name = "Kamran",
                Phone = "+994553768797",
                Surname = "Qasimov",
                JoiningDate = DateTime.Now
            });
            context.Admins.AddOrUpdate(new Admin
            {
                Id = 1,
                EmployeeId = 1
            });
            context.Doctors.AddOrUpdate(new Doctor
            {
                Id = 1,
                Address = "Ganja ave. 80/81",
                Avatar = "doctor-thumb-02.jpg",
                BirthDate = DateTime.Now,
                City = "Baku",
                Country = "Azerbaijan",
                EmployeeId = 2,
                PinCode = "5315",
                ShortBiography = "I am new doctor here",
                JopPosition = "Cardiology"
            }, new Doctor
            {
                Id = 2,
                Address = "Ganja ave. 80/81",
                Avatar = "doctor-thumb-03.jpg",
                BirthDate = DateTime.Now,
                City = "Baku",
                Country = "Azerbaijan",
                EmployeeId = 3,
                PinCode = "5478",
                ShortBiography = "I am old doctor here",
                JopPosition = "Dentist"
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

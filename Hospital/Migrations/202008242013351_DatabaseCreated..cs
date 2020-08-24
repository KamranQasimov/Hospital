namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PinCode = c.String(),
                        Address = c.String(),
                        Avatar = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        JopPosition = c.String(),
                        ShortBiography = c.String(),
                        ScheduleId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Experience_Id = c.Int(),
                        Admin_Id = c.Int(),
                        Reception_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Experiences", t => t.Experience_Id)
                .ForeignKey("dbo.Admins", t => t.Admin_Id)
                .ForeignKey("dbo.Receptions", t => t.Reception_Id)
                .Index(t => t.EmployeeId)
                .Index(t => t.Experience_Id)
                .Index(t => t.Admin_Id)
                .Index(t => t.Reception_Id);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Avatar = c.String(),
                        Gender = c.Int(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        AppointmentId = c.Int(nullable: false),
                        TreatmentPeriod = c.DateTime(nullable: false),
                        Admin_Id = c.Int(),
                        Reception_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Admin_Id)
                .ForeignKey("dbo.Receptions", t => t.Reception_Id)
                .Index(t => t.Admin_Id)
                .Index(t => t.Reception_Id);
            
            CreateTable(
                "dbo.Illnesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
            CreateTable(
                "dbo.EducationInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Institution = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Subject = c.String(),
                        Degree = c.String(),
                        Grade = c.String(),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Email = c.String(),
                        AppUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppUsers", t => t.AppUserId, cascadeDelete: true)
                .Index(t => t.AppUserId);
            
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Location = c.String(),
                        JopPosition = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Message = c.String(),
                        Reception_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Id)
                .ForeignKey("dbo.Receptions", t => t.Reception_Id)
                .Index(t => t.Id)
                .Index(t => t.Reception_Id);
            
            CreateTable(
                "dbo.Receptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Admin_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Admins", t => t.Admin_Id)
                .Index(t => t.EmployeeId)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.PatientDoctors",
                c => new
                    {
                        Patient_Id = c.Int(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Patient_Id, t.Doctor_Id })
                .ForeignKey("dbo.Patients", t => t.Patient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id, cascadeDelete: true)
                .Index(t => t.Patient_Id)
                .Index(t => t.Doctor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receptions", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Schedules", "Reception_Id", "dbo.Receptions");
            DropForeignKey("dbo.Patients", "Reception_Id", "dbo.Receptions");
            DropForeignKey("dbo.Receptions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Doctors", "Reception_Id", "dbo.Receptions");
            DropForeignKey("dbo.Patients", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Admins", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Doctors", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Schedules", "Id", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "Experience_Id", "dbo.Experiences");
            DropForeignKey("dbo.Doctors", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "AppUserId", "dbo.AppUsers");
            DropForeignKey("dbo.EducationInformations", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Illnesses", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.PatientDoctors", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.PatientDoctors", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "Id", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.PatientDoctors", new[] { "Doctor_Id" });
            DropIndex("dbo.PatientDoctors", new[] { "Patient_Id" });
            DropIndex("dbo.Receptions", new[] { "Admin_Id" });
            DropIndex("dbo.Receptions", new[] { "EmployeeId" });
            DropIndex("dbo.Schedules", new[] { "Reception_Id" });
            DropIndex("dbo.Schedules", new[] { "Id" });
            DropIndex("dbo.Employees", new[] { "AppUserId" });
            DropIndex("dbo.EducationInformations", new[] { "DoctorId" });
            DropIndex("dbo.Illnesses", new[] { "Patient_Id" });
            DropIndex("dbo.Patients", new[] { "Reception_Id" });
            DropIndex("dbo.Patients", new[] { "Admin_Id" });
            DropIndex("dbo.Appointments", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "Id" });
            DropIndex("dbo.Doctors", new[] { "Reception_Id" });
            DropIndex("dbo.Doctors", new[] { "Admin_Id" });
            DropIndex("dbo.Doctors", new[] { "Experience_Id" });
            DropIndex("dbo.Doctors", new[] { "EmployeeId" });
            DropIndex("dbo.Admins", new[] { "EmployeeId" });
            DropTable("dbo.PatientDoctors");
            DropTable("dbo.Receptions");
            DropTable("dbo.Schedules");
            DropTable("dbo.Experiences");
            DropTable("dbo.AppUsers");
            DropTable("dbo.Employees");
            DropTable("dbo.EducationInformations");
            DropTable("dbo.Illnesses");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
            DropTable("dbo.Doctors");
            DropTable("dbo.Admins");
        }
    }
}

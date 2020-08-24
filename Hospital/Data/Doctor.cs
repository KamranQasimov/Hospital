using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public class Doctor
    {
        public Doctor()
        {
            Appointments = new HashSet<Appointment>();
            Patients = new HashSet<Patient>();
            EducationInformations = new HashSet<EducationInformation>();
        }
        public int Id { get; set; }
        public string PinCode { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public enum Gender { }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string JopPosition { get; set; }
        public string ShortBiography { get; set; }
        public Schedule Schedule { get; set; }
        public int ScheduleId { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<EducationInformation> EducationInformations { get; set; }
        public Experience Experience { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
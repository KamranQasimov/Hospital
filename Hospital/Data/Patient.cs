using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Patient
    {
        public Patient()
        {
            Doctors = new HashSet<Doctor>();
            Illnesses = new HashSet<Illness>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public Appointment Appointment { get; set; }
        public int AppointmentId { get; set; }
        public DateTime TreatmentPeriod { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Illness> Illnesses { get; set; }
    }
}
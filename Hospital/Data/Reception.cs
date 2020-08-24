using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public class Reception
    {
        public Reception()
        {
            Doctors = new HashSet<Doctor>();
            Patients = new HashSet<Patient>();
            Schedules = new HashSet<Schedule>();
        }
        public int Id { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
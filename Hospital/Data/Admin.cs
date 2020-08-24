using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public class Admin
    {
        public Admin()
        {
            Doctors = new HashSet<Doctor>();
            Receptions = new HashSet<Reception>();
            Patients = new HashSet<Patient>();
        }
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Reception> Receptions { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
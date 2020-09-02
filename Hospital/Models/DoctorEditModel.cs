using Hospital.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Model
{
    public class DoctorEditModel
    {
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
        public int ScheduleId { get; set; }
        public EmployeeEditModel Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
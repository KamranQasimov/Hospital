using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public class EducationInformation
    {
        public int Id { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Subject { get; set; }
        public string Degree { get; set; }
        public string Grade { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
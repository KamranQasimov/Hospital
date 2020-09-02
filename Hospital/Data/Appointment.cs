using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public class Appointment
    {
        [ForeignKey("Patient")]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public string Message { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Model
{
    public class EmployeeEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public AppUserEditModel AppUser { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public class Experience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string JopPosition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
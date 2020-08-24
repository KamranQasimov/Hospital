using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Data
{
    public enum UserType
    {
        Admin,
        Doctor,
        Reception
    }
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50,MinimumLength =3)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 8)]
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
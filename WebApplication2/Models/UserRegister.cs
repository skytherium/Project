using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserRegister
    {
        [Key]
        public string Credential { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
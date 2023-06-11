using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class zapovednik
    {
        [Key]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; } //= new List <>();
    }
}
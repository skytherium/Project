    using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace WebApplication2
{
    public class DataRequest
    {
        [Key]
        public string Username{ get; set; }
        public List<string> Products { get; set; }
    }
}
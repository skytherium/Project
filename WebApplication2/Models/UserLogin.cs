using System.ComponentModel.DataAnnotations;

namespace WorldVision.Web.Models
{
    public class UserLogin
    {
        [Key]
        public string Credential { get; set; }
        public string Password { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace ReadyToEat.Models
{
    public class Login
    {
        public int Id{get; set;}
        [Required]
        public string usuario { get; set; }
        [Required]
        public string password1 { get; set; }
         public RegistroRest RegistroRest { get; set; }
        public int RegistroRestId { get; set; }
    }
}
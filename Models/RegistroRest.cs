using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReadyToEat.Models
{
    public class RegistroRest
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public string username{ get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public int telefono { get; set; }
        [Required]
        public string nombretienda { get; set; }
        public string imagen { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string ruc { get; set; }
        [Required]
        public string descripcion { get; set; }
        [Required]
        public string password1 { get; set; }

        public List<comentario> comentario {get; set;}
        public List<Menu> menu {get; set;}
        
    }
}
using System.ComponentModel.DataAnnotations;

namespace ReadyToEat.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public int precio { get; set; }
        
        public string imagen { get; set; }
        [Required]
        public string descripcion { get; set; }

        public RegistroRest registro { get; set; }
        public int registroId { get; set; }
    }
}
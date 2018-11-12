namespace ReadyToEat.Models
{
    public class comentario
    {
        public int Id { get; set; }
        public string asunto { get; set; }
         public RegistroRest RegistroRest { get; set; }
        public int RegistroRestId { get; set; }
        public string detalle { get; set; }
       
    }
}
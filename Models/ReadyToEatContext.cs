using Microsoft.EntityFrameworkCore;


namespace ReadyToEat.Models
{
    public class ReadyToEatContext: DbContext
    {
        public ReadyToEatContext(DbContextOptions<ReadyToEatContext> options): base(options){
            

        }
        public DbSet<Login> Iniciar{get; set;}

        public DbSet<RegistroRest> Registro{get; set;}
        public DbSet<Menu> Menu {get; set;}
        public DbSet<comentario> comentarios{get; set;}
    }
}
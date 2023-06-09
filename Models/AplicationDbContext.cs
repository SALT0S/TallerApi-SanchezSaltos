using Microsoft.EntityFrameworkCore;

namespace TallerApi_SanchezSaltos.Modelos
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { 
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
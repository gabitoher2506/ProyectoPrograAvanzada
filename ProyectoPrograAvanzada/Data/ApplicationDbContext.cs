using Microsoft.EntityFrameworkCore;
using ProyectoPrograAvanzada.Models;

namespace ProyectoPrograAvanzada.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Enfermero> Enfermeros { get; set; }
        public DbSet<Pokedex> Pokedex { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Reto> Retos { get; set; }
    }
}

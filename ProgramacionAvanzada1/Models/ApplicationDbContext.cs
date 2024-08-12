using Microsoft.EntityFrameworkCore;
using ProgramacionAvanzada1.Models;

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
    public DbSet<Pokedex> Pokedexes { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Mensaje> Mensajes { get; set; }
    public DbSet<Reto> Retos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

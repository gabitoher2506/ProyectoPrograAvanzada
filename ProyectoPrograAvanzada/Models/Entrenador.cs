namespace ProyectoPrograAvanzada.Models
{
    public class Entrenador
    {
        public int ID { get; set; }
        public string? Equipo { get; set; } 

        public Usuario? Usuario { get; set; } 
        public ICollection<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    }
}

namespace ProyectoPrograAvanzada.Models
{
    public class Reto
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string? Resultado { get; set; }

        public int? EntrenadorID1 { get; set; }
        public Entrenador? Entrenador1 { get; set; }

        public int? EntrenadorID2 { get; set; }
        public Entrenador? Entrenador2 { get; set; }
    }
}

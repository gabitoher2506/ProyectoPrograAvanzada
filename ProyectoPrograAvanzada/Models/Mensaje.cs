namespace ProyectoPrograAvanzada.Models
{
    public class Mensaje
    {
        public int ID { get; set; }
        public string? Contenido { get; set; }
        public DateTime Fecha { get; set; }

        public int? EmisorID { get; set; }
        public Entrenador? Emisor { get; set; }

        public int? ReceptorID { get; set; }
        public Entrenador? Receptor { get; set; }
    }
}

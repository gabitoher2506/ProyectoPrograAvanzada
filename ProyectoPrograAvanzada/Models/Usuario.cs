namespace ProyectoPrograAvanzada.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        public Usuario()
        {
            Nombre = string.Empty;
            User = string.Empty;
            Contrasena = string.Empty;
            Rol = string.Empty;
        }
    }
}

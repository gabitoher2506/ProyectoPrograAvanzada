namespace ProgramacionAvanzada1.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Mensaje
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Contenido { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [ForeignKey("EmisorID")]
        public virtual Entrenador Emisor { get; set; }

        public int? EmisorID { get; set; }

        [ForeignKey("ReceptorID")]
        public virtual Entrenador Receptor { get; set; }

        public int? ReceptorID { get; set; }
    }


}

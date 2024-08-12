namespace ProgramacionAvanzada1.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Reto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public string Resultado { get; set; }

        [ForeignKey("EntrenadorID1")]
        public virtual Entrenador Entrenador1 { get; set; }

        public int? EntrenadorID1 { get; set; }

        [ForeignKey("EntrenadorID2")]
        public virtual Entrenador Entrenador2 { get; set; }

        public int? EntrenadorID2 { get; set; }
    }



}

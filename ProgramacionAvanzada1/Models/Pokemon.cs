namespace ProgramacionAvanzada1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Pokemon
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Tipo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Debilidad { get; set; }

        public string Evoluciones { get; set; }

        public decimal? Peso { get; set; }

        [Required]
        public int Numero { get; set; }

        [ForeignKey("EntrenadorID")]
        public virtual Entrenador Entrenador { get; set; }

        public int? EntrenadorID { get; set; }
    }



}

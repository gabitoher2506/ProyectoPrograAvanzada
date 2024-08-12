namespace ProgramacionAvanzada1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Enfermero
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ID")]
        public virtual Usuario Usuario { get; set; }
    }

}

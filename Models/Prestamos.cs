using System.ComponentModel.DataAnnotations;

namespace Prueba2.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required (ErrorMessage ="La fecha es requerida")]
        public int fecha  { get; set; }

        [Required (ErrorMessage ="El monto  es requerido")]
        public int Monto  { get; set; }

        [Required (ErrorMessage ="El Concepto  es requerido")]
         public string? Concepto { get; set; }

        [Required (ErrorMessage ="El balance es requerido")]
        public int Balance  { get; set; }

    }
}
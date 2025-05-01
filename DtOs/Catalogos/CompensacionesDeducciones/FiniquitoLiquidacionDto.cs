using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.CompensacionesDeducciones
{
    public class FiniquitoLiquidacionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Empleado")]
        public string EmpleadoId { get; set; }

        [Display(Name = "Fecha del Finiquito")]
        public DateTime FechaFiniquito { get; set; }

        [Display(Name = "Conceptos")]
        public string Conceptos { get; set; }

        [Display(Name = "ISR Calculado")]
        public decimal? IsrCalculado { get; set; }

        [Display(Name = "Total del Finiquito")]
        public decimal? TotalFiniquito { get; set; }

        [Display(Name = "Auditoría")]
        public Auditable Auditoria { get; set; }
    }
}

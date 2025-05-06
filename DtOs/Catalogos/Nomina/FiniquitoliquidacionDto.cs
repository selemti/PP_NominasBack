// Dtos/Catalogos/Nomina/FiniquitoLiquidacionDto.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class FiniquitoLiquidacionDto
    {
        [Display(Name = "Empleado")]
        [Required]
        public string EmpleadoId { get; set; } = null!;

        [Display(Name = "Fecha de finiquito")]
        [Required]
        public DateTime FechaFiniquito { get; set; }

        [Display(Name = "ISR calculado")]
        [Required]
        public decimal IsrCalculado { get; set; }

        [Display(Name = "Total finiquito")]
        [Required]
        public decimal TotalFiniquito { get; set; }

        [Display(Name = "Conceptos")]
        public List<ConceptoFiniquitoDto> Conceptos { get; set; } = new();
    }
}

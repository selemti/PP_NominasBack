using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class CuotaObreroPatronalDto
    {
        [Display(Name = "ID de la cuota")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Concepto (Ej: Enfermedad, Retiro)")]
        [Required]
        public List<string> Concepto { get; set; }

        [Display(Name = "% Aportación patronal (actualizable)")]
        [Required]
        public List<decimal?> PorcentajePatron { get; set; }

        [Display(Name = "% Aportación empleado")]
        [Required]
        public List<decimal?> PorcentajeEmpleado { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        [Required]
        public List<DateTime?> VigenciaInicio { get; set; }

        [Display(Name = "Fecha de fin de vigencia")]
        [Required]
        public List<DateTime?> VigenciaFin { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}

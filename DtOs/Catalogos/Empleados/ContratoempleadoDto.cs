using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class ContratoEmpleadoDto
    {
        [Display(Name = "ID del contrato laboral")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Tipo de contrato (0 = Indeterminado, 1 = Temporal, etc.)")]
        [Required]
        public List<int?> TipoContrato { get; set; }

        [Display(Name = "FechaInicioContrato")]
        [Required]
        public List<DateTime?> FechaInicioContrato { get; set; }

        [Display(Name = "Fin de vigencia (nullable)")]
        [Required]
        public List<DateTime?> FechaFinContrato { get; set; }

        [Display(Name = "Indica si es el contrato activo")]
        [Required]
        public List<bool?> vigente { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}

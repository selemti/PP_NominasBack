using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class HistorialPlazaEmpleadoDto
    {
        [Display(Name = "ID único del cambio de plaza")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado involucrado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Plaza anterior del empleado")]
        [Required]
        public List<string> PlazaIdAnterior { get; set; }

        [Display(Name = "Nueva plaza asignada al empleado")]
        [Required]
        public List<string> PlazaIdNueva { get; set; }

        [Display(Name = "Fecha del cambio de plaza")]
        [Required]
        public List<DateTime?> FechaCambio { get; set; }

        [Display(Name = "Motivo del cambio de plaza")]
        [Required]
        public List<string> MotivoCambio { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}

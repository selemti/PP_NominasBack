using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Vacaciones
{
    public class VacacionesDto
    {
        [Display(Name = "ID de la solicitud de vacaciones")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado solicitante")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Fecha de inicio de vacaciones")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fecha de regreso")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "Número de días solicitados")]
        [Required]
        public List<int?> DiasProgramados { get; set; }

        [Display(Name = "Número real de días disfrutados")]
        [Required]
        public List<int?> DiasGozados { get; set; }

        [Display(Name = "Periodo vacacional aplicable")]
        [Required]
        public List<string> PeriodoVacacionalId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}

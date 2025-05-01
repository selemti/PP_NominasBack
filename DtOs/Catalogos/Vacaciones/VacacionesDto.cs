using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Vacaciones
{
    public class VacacionesDto
    {
        /// Empleado solicitante
        public string? EmpleadoId { get; set; }

        /// Fecha de inicio de vacaciones
        [Required]
        public DateTime FechaInicio { get; set; }

        /// Fecha de regreso
        [Required]
        public DateTime FechaFin { get; set; }

        /// Número de días solicitados
        public string DiasProgramados { get; set; }

        /// Número real de días disfrutados
        public string DiasGozados { get; set; }

        /// Periodo vacacional aplicable
        public string? PeriodoVacacionalId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
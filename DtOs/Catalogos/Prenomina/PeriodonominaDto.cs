using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Prenómina
{
    public class PeriodonominaDto
    {
        /// Fecha de inicio del periodo
        [Required]
        public DateTime FechaInicio { get; set; }

        /// Fecha de fin del periodo
        [Required]
        public DateTime FechaFin { get; set; }

        /// Tipo de periodo (quincenal, semanal, etc.)
        public string? TipoPeriodoId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

        /// (0 = Administrativo, 1 = Crew, 2 = Overhead)
        [Required]
        public TipoNominaEnum TipoNomina { get; set; }

    }
}
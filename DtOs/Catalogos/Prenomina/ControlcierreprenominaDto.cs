using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Prenómina
{
    public class ControlcierreprenominaDto
    {
        /// Periodo de nómina relacionado
        public string? PeriodoNominaId { get; set; }

        /// Fecha real de cierre
        [Required]
        public DateTime FechaCierre { get; set; }

        /// Usuario que cerró el periodo
        public string? UsuarioCierreId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Prenómina
{
    public class HistorialvalidacionDto
    {
        /// Periodo de nómina validado
        public string? PeriodoNominaId { get; set; }

        /// Usuario que realizó la validación
        public string? UsuarioValidadorId { get; set; }

        /// Resultado (Aprobado, Rechazado)
        public string Resultado { get; set; }

        /// Timestamp de validación
        [Required]
        public DateTime FechaValidacion { get; set; }

        /// Comentarios de validación
        public string? Observaciones { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Deducciones
{
    public class EmpleadodeduccionDto
    {
        /// Empleado afectado
        public string? EmpleadoId { get; set; }

        /// Deducción aplicada
        public string? DeduccionId { get; set; }

        /// Valor a deducir
        public string Valor { get; set; }

        /// (0 = Única, 1 = Mensual, 2 = Quincenal)
        [Required]
        public PeriodicidadEnum Periodicidad { get; set; }

        /// Inicio de la deducción
        [Required]
        public DateTime FechaInicio { get; set; }

        /// Fin (nullable)
        [Required]
        public DateTime FechaFin { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
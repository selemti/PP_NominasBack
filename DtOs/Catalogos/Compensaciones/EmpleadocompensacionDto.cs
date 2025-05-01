using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Compensaciones
{
    public class EmpleadocompensacionDto
    {
        /// Empleado relacionado
        public string? EmpleadoId { get; set; }

        /// Compensación aplicada (Bono, Comisión, Premio)
        public string? CompensacionId { get; set; }

        /// Monto asignado o fórmula base
        public string Valor { get; set; }

        /// (0 = Fijo, 1 = Variable, 2 = Por Meta)
        [Required]
        public TipoAsignacionEnum TipoAsignacion { get; set; }

        /// Fórmula o condición especial aplicable (opcional)
        public string Formula { get; set; }

        /// (0 = Única, 1 = Mensual, 2 = Quincenal)
        [Required]
        public PeriodicidadEnum Periodicidad { get; set; }

        /// Fecha de inicio de vigencia
        [Required]
        public DateTime FechaInicio { get; set; }

        /// Fecha de fin de vigencia (nullable)
        [Required]
        public DateTime FechaFin { get; set; }

        /// ¿Asignación activa?
        [Required]
        public bool Vigente { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
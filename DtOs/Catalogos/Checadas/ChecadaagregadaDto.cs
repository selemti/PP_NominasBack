using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Checadas
{
    public class ChecadaagregadaDto
    {
        /// Empleado relacionado
        public string? EmpleadoId { get; set; }

        /// Fecha de la checada agregada
        [Required]
        public DateTime Fecha { get; set; }

        /// Hora de entrada agregada
        public string HoraEntrada { get; set; }

        /// Hora de salida agregada
        public string HoraSalida { get; set; }

        /// Notas sobre la modificación
        public string? Observaciones { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
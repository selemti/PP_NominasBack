using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Biometría
{
    public class LogssincronizacionDto
    {
        /// Dispositivo involucrado
        public string? DispositivoId { get; set; }

        /// Fecha y hora del evento de sincronización
        [Required]
        public DateTime FechaEvento { get; set; }

        /// Mensaje del evento
        public string DescripcionLog { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
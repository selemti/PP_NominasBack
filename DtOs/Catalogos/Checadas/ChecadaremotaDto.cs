using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Checadas
{
    public class ChecadaremotaDto
    {
        /// Empleado que hizo la checada
        public string? EmpleadoId { get; set; }

        /// Timestamp exacto de checada
        [Required]
        public DateTime FechaHora { get; set; }

        /// Tipo (0=Entrada, 1=Salida)
        [Required]
        public TipoEventoEnum TipoEvento { get; set; }

        /// Latitud del punto de checada
        public string Latitud { get; set; }

        /// Longitud del punto
        public string Longitud { get; set; }

        /// Zona válida donde se checó
        public string? UbicacionId { get; set; }

        /// URL de la selfie de checada
        public string FotoAdjunta { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
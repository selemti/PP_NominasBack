using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Biometría
{
    public class TipoeventobiometricoDto
    {
        /// Nombre del evento (entrada, salida, comida, etc.)
        public string NombreEvento { get; set; }

        /// Descripción detallada del evento
        public string DescripcionEvento { get; set; }

        /// Estatus activo del tipo de evento
        [Required]
        public bool Activo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
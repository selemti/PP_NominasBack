using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Organización
{
    public class CentrotrabajoDto
    {
        /// Nombre del centro de trabajo
        public string NombreCentroTrabajo { get; set; }

        /// Clave oficial ante IMSS
        public string ClaveCentroTrabajo { get; set; }

        /// Dirección principal
        public string? DireccionId { get; set; }

        /// Número de registro patronal
        public string RegistroPatronal { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
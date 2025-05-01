using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Vacaciones
{
    public class PeriodovacacionalDto
    {
        /// Año aplicable
        public string Anio { get; set; }

        /// Días asignados anuales
        public string DiasAsignados { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
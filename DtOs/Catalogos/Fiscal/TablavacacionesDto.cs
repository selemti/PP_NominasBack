using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Fiscal
{
    public class TablavacacionesDto
    {
        /// Años mínimos cumplidos
        public string AniosAntiguedadMinimo { get; set; }

        /// Años máximos cumplidos
        public string AniosAntiguedadMaximo { get; set; }

        /// Días de vacaciones otorgados
        public string DiasVacaciones { get; set; }

        /// Año fiscal aplicable
        public string EjercicioFiscal { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
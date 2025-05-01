using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Prenómina
{
    public class TipoperiodoDto
    {
        /// Nombre descriptivo (Quincenal, Semanal)
        public string NombreTipoPeriodo { get; set; }

        /// Número de días en el periodo
        public string DiasPeriodo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Compensaciones
{
    public class TabuladorsalarialDto
    {
        /// Puesto relacionado
        public string? PuestoId { get; set; }

        /// Salario mínimo para puesto
        public string SalarioMinimo { get; set; }

        /// Salario máximo para puesto
        public string SalarioMaximo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
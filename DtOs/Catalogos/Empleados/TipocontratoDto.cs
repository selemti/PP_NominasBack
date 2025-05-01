using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Empleados
{
    public class TipocontratoDto
    {
        /// Nombre del contrato
        public string NombreContrato { get; set; }

        /// Descripción del tipo de contrato
        public string DescripcionContrato { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
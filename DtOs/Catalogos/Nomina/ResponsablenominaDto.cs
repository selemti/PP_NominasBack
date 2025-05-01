using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class ResponsablenominaDto
    {
        /// Usuario que ejecuta o valida nómina
        public string? UsuarioId { get; set; }

        /// Tipo (0 = Ejecutor, 1 = Validador)
        [Required]
        public TipoResponsabilidadEnum TipoResponsabilidad { get; set; }

        /// Centro de pago relacionado
        public string? CentroPagoNominaId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
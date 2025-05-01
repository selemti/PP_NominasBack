using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Alertas
{
    public class DestinatarioalertaDto
    {
        /// Alerta relacionada
        public string? AlertaId { get; set; }

        /// (0 = Usuario, 1 = Rol, 2 = Correo Libre)
        [Required]
        public TipoDestinatarioEnum TipoDestinatario { get; set; }

        /// Valor destino (ID de usuario, ID de rol, o correo)
        public string ValorDestino { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}
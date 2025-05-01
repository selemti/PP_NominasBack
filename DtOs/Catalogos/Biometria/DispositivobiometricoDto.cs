using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Biometría
{
    public class DispositivobiometricoDto
    {
        /// Modelo del dispositivo
        public string Modelo { get; set; }

        /// Número de serie del dispositivo
        public string NumeroSerie { get; set; }

        /// IP de red asignada
        public string IpAsignada { get; set; }

        /// Tipo (0 = Biométrico, 1 = Facial, 2 = Huella)
        [Required]
        public TipoDispositivoEnum TipoDispositivo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

        /// Referencia al Centro de Trabajo
        public string? CentroID { get; set; }

    }
}